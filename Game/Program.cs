using System;
using System.Threading;
using System.Net;

namespace Game
{
  class MainClass : Util.IKeyboardListener
  {
    public void Update(ConsoleKeyInfo key)
    {
      Console.WriteLine("From ConsoleKeyboard: {0}, {1}, {2}", key.Key, key.KeyChar, key.Modifiers);
    }

    private MainClass()
    {
      Util.ConsoleKeyboard.Get.Add(this);
    }

    public static void Main(string[] args)
    {
      new MainClass();
      var stop = new ManualResetEvent(false);
      X11.MessageLoop.Get.OnKeyRelease += key =>
      {
        Console.WriteLine("\nKey {0} released", key);
        if (key == X11.Key.Escape) stop.Set();
      };

      X11.MessageLoop.Get.OnKeyPress += key => Console.WriteLine("\nKey {0} pressed", key);
      X11.MessageLoop.Get.OnConfigure += () => Console.WriteLine("OnConfigure");
      X11.MessageLoop.Get.OnEnterLeave += result => Console.WriteLine("OnEnterLeave: {0}", result);
      X11.MessageLoop.Get.OnExpose += () => Console.WriteLine("OnExpose");
      X11.MessageLoop.Get.OnFocus += result => Console.WriteLine("OnFocus: {0}", result);
      X11.MessageLoop.Get.OnProperty += state => Console.WriteLine("OnProperty: {0}", state);
      X11.MessageLoop.Get.OnVisibility += () => Console.WriteLine("OnVisibility");

      stop.WaitOne();
    }
  }
}
