using Util;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      new Game().Run();
      ConsoleScreen.Clear();
      X11.MessageLoop.Get.Stop();
    }
  }
}

