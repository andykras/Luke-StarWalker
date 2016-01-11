using System;
using System.Threading;

namespace Game
{
  class MainClass
  {
    static ManualResetEvent stop = new ManualResetEvent(false);
    public static void Main(string[] args)
    {
      X11.MessageLoop.Get.OnKeyRelease += key =>
      {
        Console.WriteLine("\nKey {0} pressed", key);
        if (key == X11.Key.Escape) stop.Set();
      };

      X11.MessageLoop.Get.OnConfigure += () => Console.WriteLine("OnConfigure");
      X11.MessageLoop.Get.OnEnterLeave += result => Console.WriteLine("OnEnterLeave: {0}", result);
      X11.MessageLoop.Get.OnExpose += () => Console.WriteLine("OnExpose");
      X11.MessageLoop.Get.OnFocus += result => Console.WriteLine("OnFocus: {0}", result);
      X11.MessageLoop.Get.OnProperty += state => Console.WriteLine("OnProperty: {0}", state);
      X11.MessageLoop.Get.OnVisibility += () => Console.WriteLine("OnVisibility");

      stop.WaitOne();
      X11.MessageLoop.Get.Stop();
    }
  }
}
