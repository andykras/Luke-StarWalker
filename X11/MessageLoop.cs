using System;
using System.Threading;

namespace X11
{
  public sealed class MessageLoop : IDisposable
  {
    public event Action OnConfigure=delegate{};
    public event Action<Key> OnKeyPress=delegate{};
    public event Action<Key> OnKeyRelease=delegate{};
    public event Action OnClientMessage=delegate{};
    public event Action<int> OnProperty=delegate{};
    public event Action OnVisibility=delegate{};
    public event Action OnExpose=delegate{};
    public event Action<bool> OnFocus=delegate{};
    public event Action<bool> OnEnterLeave=delegate{};

    bool stop;
    IntPtr display;
    IntPtr window;

    public MessageLoop() : this(IntPtr.Zero) {}

    public MessageLoop(IntPtr winPtr)
    {
      window = winPtr;
      new Thread(Loop){ IsBackground = true }.Start();
    }

    private void Loop()
    {
      display = X11lib.XOpenDisplay(null);
      if (display == IntPtr.Zero) return;
      if (window == IntPtr.Zero) {
        int res = 0;
        X11lib.XGetInputFocus(display, ref window, ref res);
        if (window == IntPtr.Zero) return;
      }

      // TODO: move grabkeyboard to separate class
      bool grabKeyboard = false;
      if (grabKeyboard) {
        var rootWindow = X11lib.XDefaultRootWindow(display);
        window = X11lib.XCreateSimpleWindow(display, rootWindow, -1, -1, 1, 1, 0, X11lib.XBlackPixel(display, 0), X11lib.XWhitePixel(display, 0));
        X11lib.XLowerWindow(display, window);
      }

      X11lib.XSelectInput(display, window,
                          EventMask.StructureNotifyMask
                          | EventMask.ExposureMask
                          | EventMask.KeyPressMask
                          | EventMask.KeyReleaseMask
                          | EventMask.EnterWindowMask
                          | EventMask.LeaveWindowMask
                          | EventMask.FocusChangeMask
                          | EventMask.PropertyChangeMask
                          | EventMask.VisibilityChangeMask
      );
      X11lib.XMapWindow(display, window);

      if (grabKeyboard) {
        var e2 = new XEvent { type = XEventName.None };
        do {
          X11lib.XNextEvent(display, ref e2);
        } while (e2.type != XEventName.MapNotify);

        X11lib.XGrabKeyboard(display, window, false, 1, 1, 0);
        X11lib.XLowerWindow(display, window);
      }

      var e = new XEvent { type = XEventName.None };
      do {
        switch (e.type) {
          case XEventName.ConfigureNotify:
            OnConfigure();
            break;
          case XEventName.Expose:
            // The count member is set to the number of Expose events that are to follow.
            // If count is zero, no more Expose events follow for this window.
            // However, if count is nonzero, at least that number of Expose events (and possibly more) follow for this window.
            // Simple applications that do not want to optimize redisplay by distinguishing between subareas of its window
            // can just ignore all Expose events with nonzero counts and perform full redisplays on events with zero counts.
            if (e.ExposeEvent.count == 0) OnExpose();
            break;
          case XEventName.KeyPress:
            //var mod = (Modifier) X.XkbKeysymToModifiers(display, X.XKeycodeToKeysym(display, e.KeyEvent.keycode, 0));
            OnKeyPress((Key) X11lib.XKeycodeToKeysym(display, e.KeyEvent.keycode, 0));
            break;
          case XEventName.KeyRelease:
            OnKeyRelease((Key) X11lib.XKeycodeToKeysym(display, e.KeyEvent.keycode, 0));
            break;
          case XEventName.EnterNotify:
            OnEnterLeave(true);
            break;
          case XEventName.LeaveNotify:
            OnEnterLeave(false);
            break;
          case XEventName.FocusIn:
            OnFocus(true);
            break;
          case XEventName.FocusOut:
            OnFocus(false);
            break;
          case XEventName.PropertyNotify:
            // state - PropertyNewValue or PropertyDelete
            OnProperty(e.PropertyEvent.state);
            break;
          case XEventName.VisibilityNotify:
            OnVisibility();
            break;
          case XEventName.ClientMessage:
            OnClientMessage();
            break;
        }
        X11lib.XNextEvent(display, ref e);
      } while (!stop);
      X11lib.XCloseDisplay(display);
      display = IntPtr.Zero;
      window = IntPtr.Zero;
    }

    static void SendFakeEventToStop(IntPtr w)
    {
      var d = X11lib.XOpenDisplay(null);
      if (d == IntPtr.Zero) return;
      var e = new XEvent{ type = XEventName.PropertyNotify };
      X11lib.XSendEvent(d, w, true, EventMask.PropertyChangeMask, ref e);
      X11lib.XCloseDisplay(d);
    }

    public void Dispose()
    {
      stop = true;
      SendFakeEventToStop(window);
    }
  }
}

