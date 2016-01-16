using System;
using System.Threading;

namespace X11
{
  public class MessageLoop
  {
    public event Action OnConfigure=delegate{};
    public event Action<Key> OnKeyPress=delegate{};
    public event Action<Key> OnKeyRelease=delegate{};
    public event Action OnWindowClosed=delegate{};
    public event Action<int> OnProperty=delegate{};
    public event Action OnVisibility=delegate{};
    public event Action OnExpose=delegate{};
    public event Action<bool> OnFocus=delegate{};
    public event Action<bool> OnEnterLeave=delegate{};

    public static MessageLoop Get { get; }

    static MessageLoop()
    {
      Get = new MessageLoop();
    }

    private bool stop;
    private MessageLoop()
    {
      new Thread(Loop){ IsBackground = true }.Start();
    }

    private void Loop()
    {
      IntPtr display = FromDLL.XOpenDisplay(null);
      if (display == IntPtr.Zero) return;
      IntPtr window = IntPtr.Zero;
      int res = 0;
      FromDLL.XGetInputFocus(display, ref window, ref res);
      if (window == IntPtr.Zero) return;

      //XSetInputFocus
      bool grabKeyboard = false;
      if (grabKeyboard) {
        var rootWindow = FromDLL.XDefaultRootWindow(display);
        window = FromDLL.XCreateSimpleWindow(display, rootWindow, -1, -1, 1, 1, 0, FromDLL.XBlackPixel(display, 0), FromDLL.XWhitePixel(display, 0));
        FromDLL.XLowerWindow(display, window);
      }

      FromDLL.XSelectInput(display, window,
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
      FromDLL.XMapWindow(display, window);

      if (grabKeyboard) {
        var e2 = new XEvent { type = XEventName.None };
        do {
          FromDLL.XNextEvent(display, ref e2);
        } while (e2.type != XEventName.MapNotify);

        FromDLL.XGrabKeyboard(display, window, false, 1, 1, 0);
        FromDLL.XLowerWindow(display, window);
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
            OnKeyPress((Key) FromDLL.XKeycodeToKeysym(display, e.KeyEvent.keycode, 0));
            break;
          case XEventName.KeyRelease:
            OnKeyRelease((Key) FromDLL.XKeycodeToKeysym(display, e.KeyEvent.keycode, 0));
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
            OnWindowClosed();
            Stop();
            break;
        }
        FromDLL.XNextEvent(display, ref e);
      } while (!stop);
      FromDLL.XCloseDisplay(display);
    }

    public void Stop()
    {
      stop = true;
    }
  }
}

