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
    int count, asteriks_count, timer1 = 16, timer2 = 16;
    double xc, yc, angle, angle_ship, offsetX, offsetY, deg = Math.PI / 24, R = 13, d1, d2, ratioD;
    bool show_intel, show_label, show_circle, show_dollar;

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

      X11.MessageLoop.Get.OnKeyPress += KeyPress;
      X11.MessageLoop.Get.OnKeyRelease += KeyRelease;
      X11.MessageLoop.Get.OnConfigure += Invalidate;
      X11.MessageLoop.Get.OnEnterLeave += Invalidate;
      X11.MessageLoop.Get.OnExpose += Invalidate;
      X11.MessageLoop.Get.OnFocus += Invalidate;
      X11.MessageLoop.Get.OnProperty += Invalidate;
      X11.MessageLoop.Get.OnVisibility += Invalidate;

      new Thread(Render){ IsBackground = true }.Start();
    }


    void ResetToDefault()
    {
      count = 30;
      xc = 0.0;
      yc = 0.0;
      angle = 0.0;
      angle_ship = 0.0;
      offsetX = 14.0;
      offsetY = 20.0;
      show_intel = false;
      show_label = true;
      show_circle = true;
      show_dollar = true;
      asteriks_count = 0;
      ConsoleScreen.Zoom = 1.0;
      d1 = 0.5;
      d2 = 2;
    }

    public void Run()
    {
      renderScene.Set();
      isStopped.WaitOne();
      stopped = true;
      renderScene.Set();
      X11.MessageLoop.Get.OnKeyPress -= KeyPress;
      X11.MessageLoop.Get.OnKeyRelease -= KeyRelease;
      X11.MessageLoop.Get.OnConfigure -= Invalidate;
      X11.MessageLoop.Get.OnEnterLeave -= Invalidate;
      X11.MessageLoop.Get.OnExpose -= Invalidate;
      X11.MessageLoop.Get.OnFocus -= Invalidate;
      X11.MessageLoop.Get.OnProperty -= Invalidate;
      X11.MessageLoop.Get.OnVisibility -= Invalidate;
    }

    void KeyPress(X11.Key key)
    {
      if (KeyToEvent(key, true)) processEvent.Set();
    }

    void KeyRelease(X11.Key key)
    {
      if (key == X11.Key.Escape) Close();
      KeyToEvent(key, false);
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

    void Invalidate()
    {
      renderScene.Set();
    }

    void Invalidate(bool enable)
    {
      if (enable) renderScene.Set();
    }

    void Invalidate(int state)
    {
      renderScene.Set();
    }

    void Close()
    {
      isStopped.Set();
    }
  }
}

