using System;
using System.Threading;
using Util;

namespace Game
{
  public partial class Game
  {
    PixelPainter pixel_painter;
    SpritePainter sprite_painter;
    IPainter painter;
    Random rnd;
    const int asteriks_count_max = 5000;
    double[] random_numbers;
    int count, asteriks_count, timer1 = 16, timer2 = 16, timer3 = 120;
    double xc, yc, angle, angle_ship, offsetX, offsetY, deg = Math.PI / 24, R = 13, d1, d2, ratioD;
    bool show_intel, show_label, show_circle, show_dollar, show_help, show_task, show_stat;
    ConsoleColor ship_color;
    int skull_index;

    Thread render;
    public Game()
    {
      ResetToDefault();
      ratioD = d2 / d1;

      pixel_painter = new PixelPainter();
      sprite_painter = new SpritePainter();
      painter = sprite_painter;

      rnd = new Random((int) DateTime.Now.ToBinary());
      random_numbers = new double[asteriks_count_max];
      for (var i = 0; i < asteriks_count_max; i++) random_numbers[i] = (rnd.NextGaussian(rnd.Next(-100, 100), 100 / 2));

      render = new Thread(Render){ IsBackground = true };
    }

    void ResetToDefault()
    {
      count = 30;
      xc = -217;
      yc = -205;
      angle = 0.0;
      angle_ship = 0.0;
      offsetX = 231;
      offsetY = 225;
      show_intel = false;
      show_label = false;
      show_circle = true;
      show_dollar = true;
      show_help = true;
      show_task = true;
      show_stat = true;
      asteriks_count = 666;
      ConsoleScreen.Zoom = 1;
      d1 = 0.5;
      d2 = 2;
      ship_color = ConsoleColor.Magenta;
      skull_index = -270;
    }

    void UpdateMinMax() {
      ConsoleScreen.Zoom = Math.Max(ConsoleScreen.Zoom, 0.1);
      ConsoleScreen.Zoom = Math.Min(ConsoleScreen.Zoom, 100);
      asteriks_count = Math.Min(asteriks_count, asteriks_count_max / 2);
      count = Math.Max(count, 1);
      count = Math.Min(count, 100);
      d1 = Math.Max(d1, 0);
      d1 = Math.Min(d1, 10);
      d2 = Math.Max(d2, 0);
      d2 = Math.Min(d2, d1 * ratioD);
    }

    public void Run()
    {
      render.Start();
      isStopped.WaitOne();

      // very rough
      //render.Abort();

      // more accurate
      stopped = true;
      renderScene.Set();
      render.Join();
    }

    bool isSetEvent(GameEvent eventToTest)
    {
      return (gameEvent & eventToTest) == eventToTest;
    }

    void SetEvent(GameEvent eventToSet, bool enable)
    {
      if (enable) gameEvent = gameEvent | eventToSet;
      else gameEvent = gameEvent ^ eventToSet;
    }
  }
}

