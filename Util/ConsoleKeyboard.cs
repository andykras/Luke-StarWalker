using System;
using System.Collections.Generic;
using System.Threading;

namespace Util
{
  public class ConsoleKeyboard
  {
    private bool stop;
    private readonly List<IKeyboardListener> subscribers = new List<IKeyboardListener>();
    readonly static SimpleLock simple = new SimpleLock();

    public static ConsoleKeyboard Get { get; }

    static ConsoleKeyboard()
    {
      Get = new ConsoleKeyboard();
    }

    private ConsoleKeyboard()
    {
      new Thread(ConsoleReadKey){ IsBackground = true }.Start();
    }

    private void ConsoleReadKey()
    {
      while (!stop) Fire(Console.ReadKey(true));
    }

    public void Stop()
    {
      stop = true;
    }

    public void Add(IKeyboardListener listener)
    {
      simple.Enter();
      subscribers.Add(listener);
      simple.Exit();
    }

    public void Remove(IKeyboardListener listener)
    {
      simple.Enter();
      subscribers.Remove(listener);
      simple.Exit();
    }

    private void Fire(ConsoleKeyInfo key)
    {
      simple.Enter();
      foreach (var listener in subscribers) listener.Update(key);
      simple.Exit();
    }
  }
}

