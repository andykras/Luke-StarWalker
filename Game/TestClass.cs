using System;
using System.Threading;

namespace Game
{
  class TestClass : Util.IKeyboardListener
  {
    public void Update(ConsoleKeyInfo key)
    {
      Console.WriteLine("From ConsoleKeyboard: {0}, {1}, {2}", key.Key, key.KeyChar, key.Modifiers);
    }

    private TestClass()
    {
      Util.ConsoleKeyboard.Get.Add(this);
    }

    public static void Test()
    {
      new TestClass();
      using (var loop = new X11.MessageLoop()) {

        var stop = new ManualResetEvent(false);
        loop.OnKeyRelease += key =>
        {
          Console.WriteLine("\nKey {0} released", key);
          if (key == X11.Key.Escape) stop.Set();
        };

        loop.OnKeyPress += key => Console.WriteLine("\nKey {0} pressed", key);
        loop.OnConfigure += () => Console.WriteLine("OnConfigure");
        loop.OnEnterLeave += result => Console.WriteLine("OnEnterLeave: {0}", result);
        loop.OnExpose += () => Console.WriteLine("OnExpose");
        loop.OnFocus += result => Console.WriteLine("OnFocus: {0}", result);
        loop.OnProperty += state => Console.WriteLine("OnProperty: {0}", state);
        loop.OnVisibility += () => Console.WriteLine("OnVisibility");
        stop.WaitOne();
      }
    }
  }
}
