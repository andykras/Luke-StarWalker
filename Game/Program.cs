using Util;

namespace Game
{
  public class Program
  {
    public static void Main(string[] args)
    {
      if (args.Length > 0 && args[0] == "test") {
        TestClass.Test();
        return;
      }
      new Game().Run();
      ConsoleScreen.Clear();
    }
  }
}

