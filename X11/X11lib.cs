using System;
using System.Runtime.InteropServices;

namespace X11
{
  static class X11lib
  {
    [DllImport("libX11")]
    extern public static IntPtr XInternAtom(IntPtr x11display, [MarshalAs(UnmanagedType.LPStr)] string atomName, bool onlyIfExists);

    [DllImport("libgtk-x11-2.0")]
    public static extern IntPtr gdk_x11_get_default_xdisplay();

    [DllImport("libgtk-x11-2.0")]
    public static extern IntPtr gdk_screen_get_default();

    [DllImport("libgtk-x11-2.0")]
    public static extern IntPtr gdk_screen_get_root_window(IntPtr gdkScreen);

    [DllImport("libX11")]
    extern public static int XSetWMProtocols(IntPtr x11display, IntPtr x11window, ref IntPtr protocols, int count);

    [DllImport("libX11")]
    public extern static void XPeekEvent(IntPtr display, ref XEvent x11event);

    [DllImport("libX11")]
    public extern static void XNextEvent(IntPtr x11display, ref XEvent x11event);

    [DllImport("libX11")]
    public extern static int XPending(IntPtr x11display);

    [DllImport("libgtk-x11-2.0")]
    public static extern IntPtr gdk_x11_drawable_get_xid(IntPtr gdkWindow);

    [DllImport("libgtk-x11-2.0")]
    public static extern IntPtr gdk_x11_drawable_get_xdisplay(IntPtr gdkDrawable);

    [DllImport("libgtk-x11-2.0")]
    public static extern IntPtr gdk_x11_window_get_drawable_impl(IntPtr gdkWindow);

    [DllImport("libX11")]
    extern public static IntPtr XOpenDisplay(String x11displayName);

    [DllImport("libX11")]
    extern public static void XCloseDisplay(IntPtr x11display);

    [DllImport("libX11")]
    extern public static  void XDestroyWindow(IntPtr x11display, IntPtr x11window);

    [DllImport("libX11")]
    extern public static int XDefaultScreen(IntPtr x11display);

    [DllImport("libX11")]
    extern public static IntPtr XCreateSimpleWindow(IntPtr x11display, IntPtr x11window, int x, int y, uint width, uint height, uint outsideBorderWidth, ulong border, ulong background);

    [DllImport("libX11")]
    extern public static void XLowerWindow(IntPtr x11display, IntPtr x11window);

    [DllImport("libX11")]
    extern public static int XGrabKeyboard(IntPtr display, IntPtr window, bool owner, int pointer_mode, int keyboard_mode, long time);

    [DllImport("libX11")]
    extern public static IntPtr XRootWindow(IntPtr x11display, int screenNumber);

    [DllImport("libX11")]
    extern public static IntPtr XDefaultRootWindow(IntPtr x11display);

    [DllImport("libX11")]
    extern public static ulong XBlackPixel(IntPtr x11display, int screenNumber);

    [DllImport("libX11")]
    extern public static ulong XWhitePixel(IntPtr x11display, int screenNumber);

    [DllImport("libX11")]
    extern public static void XSelectInput(IntPtr x11display, IntPtr x11window, EventMask eventMask);

    [DllImport("libX11")]
    extern public static void XMapWindow(IntPtr x11display, IntPtr x11window);

    [DllImport("libc")]
    public static extern int getpid();

    [DllImport("libX11", CharSet = CharSet.None)]
    public static extern int XGetInputFocus(IntPtr display, ref IntPtr window, ref int revertToReturn);

    [DllImport("libX11")]
    public static extern int XKeysymToKeycode(IntPtr display, int keysym);

    [DllImport("libX11")]
    public static extern int XKeycodeToKeysym(IntPtr display, int keycode, int index);

    [DllImport("libX11")]
    public static extern int XkbKeysymToModifiers(IntPtr display, int keysym);

    [DllImport("libX11")]
    public static extern int XLookupKeysym(ref XKeyEvent keyEvent, int index);

    [DllImport("libX11")]
    public static extern int  XSendEvent(IntPtr display, IntPtr w, bool propagate, EventMask mask, ref XEvent e);
  }
}
