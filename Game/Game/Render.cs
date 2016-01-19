using System;
using System.Threading;
using Util;

namespace Game
{
  public partial class Game
  {
    private readonly ManualResetEvent isStopped = new ManualResetEvent(false);
    private readonly ManualResetEvent renderScene = new ManualResetEvent(false);
    private readonly ManualResetEvent processEvent = new ManualResetEvent(false);
    GameEvent gameEvent;
    bool stopped;

    void Render()
    {
      ConsoleScreen.SetDotAsSeparator();
      RollerEvents();
      UserInputThread();

      // main render cycle
      using (var loop = new X11.MessageLoop()) {
        loop.OnKeyPress += (key) =>
        {
          if (KeyToEvent(key, true)) processEvent.Set();
        };
        loop.OnKeyRelease += (key) =>
        {
          if (key == X11.Key.Escape) isStopped.Set();
          else KeyToEvent(key, false);
        };
        loop.OnConfigure += () => renderScene.Set();
        loop.OnEnterLeave += (t) => renderScene.Set();
        loop.OnExpose += () => renderScene.Set();
        loop.OnFocus += (t) => renderScene.Set();
        loop.OnProperty += (t) => renderScene.Set();
        loop.OnVisibility += () => renderScene.Set();
        while (!stopped) {
          renderScene.Reset();
          Draw();
          Thread.Sleep(timer2);
          renderScene.WaitOne();
        }
      }
    }

    void RollerEvents() {
      // continious events thread
      new Thread(() =>
      {
        while (!stopped) {
          skull_index++;
          angle += deg * 0.05;
          renderScene.Set();
          Thread.Sleep(timer3);
        }
      }) {
        IsBackground = true
      }.Start();
    }

    void UserInputThread() {
      // user input events handler
      new Thread(() =>
      {
        while (!stopped) {
          processEvent.WaitOne();
          show_task = false;
          var speedUp = isSetEvent(GameEvent.SpeedUp);
          if (isSetEvent(GameEvent.ShipForward)) {
            var rx = (speedUp ? d2 : d1) * Math.Sin(angle_ship);
            var ry = (speedUp ? d2 : d1) * Math.Cos(angle_ship);
            offsetX += rx;
            offsetY += ry;
            xc -= rx;
            yc -= ry;
            //            xc = ConsoleScreen.Fit(xc, 0.5);
            //            yc = ConsoleScreen.Fit(yc, 0.5);
          }
          if (isSetEvent(GameEvent.ShipBackward)) {
            var rx = (speedUp ? d2 : d1) * Math.Sin(angle_ship);
            var ry = (speedUp ? d2 : d1) * Math.Cos(angle_ship);
            offsetX -= (speedUp ? d2 : d1) * Math.Sin(angle_ship);
            offsetY -= (speedUp ? d2 : d1) * Math.Cos(angle_ship);
            xc += rx;
            yc += ry;
          }
          if (isSetEvent(GameEvent.ShipStrafeLeft)) {
            offsetX -= (speedUp ? d2 : d1) * Math.Cos(-angle_ship);
            offsetY -= (speedUp ? d2 : d1) * Math.Sin(-angle_ship);
          }
          if (isSetEvent(GameEvent.ShipStrafeRight)) {
            offsetX += (speedUp ? d2 : d1) * Math.Cos(-angle_ship);
            offsetY += (speedUp ? d2 : d1) * Math.Sin(-angle_ship);
          }
          if (isSetEvent(GameEvent.Reset)) ResetToDefault();
          if (isSetEvent(GameEvent.MoveSceneUp)) yc -= speedUp ? d2 : d1;
          if (isSetEvent(GameEvent.MoveSceneDown)) yc += speedUp ? d2 : d1;
          if (isSetEvent(GameEvent.MoveSceneLeft)) xc += speedUp ? d2 : d1;
          if (isSetEvent(GameEvent.MoveSceneRight)) xc -= speedUp ? d2 : d1;
          if (isSetEvent(GameEvent.AddStar)) asteriks_count += speedUp ? 10 : 1;
          if (isSetEvent(GameEvent.RotateSceneLeft)) angle -= speedUp ? deg : deg * 0.1;
          if (isSetEvent(GameEvent.RotateSceneRight)) angle += speedUp ? deg : deg * 0.1;
          if (isSetEvent(GameEvent.ShipTurnLeft)) angle_ship -= speedUp ? deg : deg * 0.5;
          if (isSetEvent(GameEvent.ShipTurnRight)) angle_ship += speedUp ? deg : deg * 0.5;
          if (isSetEvent(GameEvent.ZoomIn)) ConsoleScreen.Zoom += speedUp ? 0.05 : 0.007;
          if (isSetEvent(GameEvent.ZoomOut)) ConsoleScreen.Zoom -= speedUp ? 0.05 : 0.007;
          if (isSetEvent(GameEvent.DeltaDec)) {
            d1 -= 0.05;
            d2 = d1 * ratioD;
          }
          if (isSetEvent(GameEvent.DeltaInc)) {
            d1 += 0.05;
            d2 = d1 * ratioD;
          }
          UpdateMinMax();
          renderScene.Set();
          if (gameEvent == GameEvent.None) processEvent.Reset();
          Thread.Sleep(timer1);
        }
      }) {
        IsBackground = true
      }.Start();
    }
  }
}