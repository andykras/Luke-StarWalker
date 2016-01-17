using Util;
using System;

namespace Game
{
  public partial class Game
  {
    bool KeyToEvent(X11.Key key, bool enable)
    {
      switch (key) {
        case X11.Key.KP_Up:
          SetEvent(GameEvent.MoveSceneUp, enable);
          break;
        case X11.Key.KP_Begin:
          SetEvent(GameEvent.MoveSceneDown, enable);
          break;
        case X11.Key.KP_Left:
          SetEvent(GameEvent.MoveSceneLeft, enable);
          break;
        case X11.Key.KP_Right:
          SetEvent(GameEvent.MoveSceneRight, enable);
          break;
        case X11.Key.e:
          SetEvent(GameEvent.ShipForward, enable);
          break;
        case X11.Key.d:
          SetEvent(GameEvent.ShipBackward, enable);
          break;
        case X11.Key.s:
          SetEvent(GameEvent.ShipTurnLeft, enable);
          break;
        case X11.Key.f:
          SetEvent(GameEvent.ShipTurnRight, enable);
          break;
        case X11.Key.w:
          SetEvent(GameEvent.ShipStrafeLeft, enable);
          break;
        case X11.Key.r:
          SetEvent(GameEvent.ShipStrafeRight, enable);
          break;
        case X11.Key.Alt_L:
          SetEvent(GameEvent.SpeedUp, enable);
          break;
        case X11.Key.KP_Add:
          SetEvent(GameEvent.ZoomIn, enable);
          break;
        case X11.Key.KP_Subtract:
          SetEvent(GameEvent.ZoomOut, enable);
          break;
        case X11.Key.KP_Divide:
          SetEvent(GameEvent.Reset, enable);
          break;
        case X11.Key.KP_Home:
          SetEvent(GameEvent.RotateSceneLeft, enable);
          break;
        case X11.Key.KP_Page_Up:
          SetEvent(GameEvent.RotateSceneRight, enable);
          break;
        case X11.Key.i:
          if (enable) show_intel = !show_intel;
          break;
        case X11.Key.l:
          if (enable) show_label = !show_label;
          break;
        case X11.Key.c:
          if (enable) show_circle = !show_circle;
          break;
        case X11.Key.Key_1:
          ship_color = (ConsoleColor) (1 + 8);
          break;
        case X11.Key.Key_2:
          ship_color = (ConsoleColor) (2 + 8);
          break;
        case X11.Key.Key_3:
          ship_color = (ConsoleColor) (3 + 8);
          break;
        case X11.Key.Key_4:
          if (enable && isSetEvent(GameEvent.ShiftPressed)) show_dollar = !show_dollar;
          if (!isSetEvent(GameEvent.ShiftPressed)) ship_color = (ConsoleColor) (4 + 8);
          break;
        case X11.Key.Key_5:
          ship_color = (ConsoleColor) (5 + 8);
          break;
        case X11.Key.Key_6:
          ship_color = (ConsoleColor) (6 + 8);
          break;
        case X11.Key.Key_7:
          ship_color = (ConsoleColor) (7 + 8);
          break;
        case X11.Key.Insert:
          if (enable) count++;
          break;
        case X11.Key.Delete:
          if (enable) count--;
          break;
        case X11.Key.o:
          SetEvent(GameEvent.DeltaDec, enable);
          //          if (enable) {
          //            d1 -= 0.05;
          //            d2 = d1 * ratioD;
          //          }
          break;
        case X11.Key.p:
          SetEvent(GameEvent.DeltaInc, enable);
          //          if (enable) {
          //            d1 += 0.05;
          //            d2 = d1 * ratioD;
          //          }
          break;
        case X11.Key.bracketleft:
          if (enable) {
            timer1 -= 1;
            timer2 -= 1;
            timer1 = Math.Max(timer1, 1);
            timer2 = Math.Max(timer2, 1);
          }
          break;
        case X11.Key.bracketright:
          if (enable) {
            timer1 += 1;
            timer2 += 1;
          }
          break;
        case X11.Key.semicolon:
          if (enable) {
            timer3 -= 10;
            timer3 = Math.Max(timer3, 30);
          }
          break;
        case X11.Key.apostrophe:
          if (enable) timer3 += 10;
          break;
        case X11.Key.KP_Enter:
          ConsoleScreen.Zoom = 1.0;
          break;
        case X11.Key.Return:
          if (enable) painter = painter == pixel_painter ? sprite_painter : pixel_painter;
          break;

        case X11.Key.KP_Multiply:
          SetEvent(GameEvent.AddStar, enable);
          break;
        case X11.Key.Shift_L:
          SetEvent(GameEvent.ShiftPressed, enable);
          break;
        case X11.Key.h:
          if (enable) show_help = !show_help;
          break;
        default:
          return false;
      }
      return true;
    }
  }
}
