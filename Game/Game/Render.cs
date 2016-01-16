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
      new Thread(delegate()
      {
        while (!stopped) {
          processEvent.WaitOne();
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
          if (isSetEvent(GameEvent.ZoomIn)) ConsoleScreen.Zoom += speedUp ? 0.1 : 0.03;
          if (isSetEvent(GameEvent.ZoomOut)) ConsoleScreen.Zoom -= speedUp ? 0.1 : 0.03;

          if (isSetEvent(GameEvent.DeltaDec)) {
            d1 -= 0.05;
            d2 = d1 * ratioD;
          }
          if (isSetEvent(GameEvent.DeltaInc)) {
            d1 += 0.05;
            d2 = d1 * ratioD;
          }

          renderScene.Set();
          Thread.Sleep(timer1);
          if (gameEvent == GameEvent.None) processEvent.Reset();
        }
      }){ IsBackground = true }.Start();

      while (!stopped) {
        renderScene.WaitOne();
        Thread.Sleep(timer2);
        Draw();
        renderScene.Reset();
      }
  }
  }
}