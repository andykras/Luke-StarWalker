using System;
using System.Collections.Generic;
using Util;

namespace Game
{
  public partial class Game
  {
    void Draw()
    {
      ConsoleScreen.Clear();
      ConsoleScreen.Zoom = Math.Max(ConsoleScreen.Zoom, 0.1);
      ConsoleScreen.Zoom = Math.Min(ConsoleScreen.Zoom, 100);
      asteriks_count = Math.Min(asteriks_count, asteriks_count_max / 2);
      count = Math.Max(count, 1);
      count = Math.Min(count, 100);
      d1 = Math.Max(d1, 0);
      d1 = Math.Min(d1, 10);
      d2 = Math.Max(d2, 0);
      d2 = Math.Min(d2, d1 * ratioD);

      // STARS
      var asteriks = new Sprite(null, angle, ConsoleColor.Yellow){ ShowLabel = show_label };
      for (var i = 0; i < asteriks_count; i++) asteriks.Add(new CharPixel('*', xc + random_numbers[2 * i], yc + random_numbers[2 * i + 1], ConsoleColor.DarkMagenta));
      if (asteriks_count != 0) asteriks.Draw(painter);

      if (!show_intel) {

        // CIRCLE
        if (show_circle) {
          var alpha = Math.PI * 2.0 / count;
          for (var i = 0; i < count; i++) {
            var x = xc + R * Math.Cos(i * alpha);
            var y = yc + R * Math.Sin(i * alpha);
            new CharPixel('█', x, y, (ConsoleColor) rnd.Next(1, 15)).Draw(pixel_painter);
          }

          var pix = new CharPixel('@', xc, yc, ConsoleColor.Yellow);
          pix.Draw(pixel_painter);

          new CharSprite(new [] { 
            " █ ",
            "███",
            "   " 
          }, xc - 3, yc + 3, angle){ ShowLabel = show_label }.Draw(painter);
        }

        if (show_dollar) {
          var dollars = new CharSprite(new[] { 
            "                      $$$$",
            "           $$$$$$$$$$$$$$$$$",
            "       $$$$$$$$$$$$$$$$$$$$$$",
            "     $$$$$$$       $$$$    $$$$$$$$",
            "   $$$$$$          $$$$        $$$$$$$",
            "  $$$$$$           $$$$          $$$$$$",
            "  $$$$$$           $$$$",
            "  $$$$$$           $$$$",
            "   $$$$$$          $$$$",
            "    $$$$$$$$      $$$$",
            "      $$$$$$$$$$$$$$$",
            "          $$$$$$$$$$$$$$$$$$",
            "                 $$$$$$$$$$$$$$$$",
            "                      $$$$ $$$$$$$$$$",
            "                      $$$$       $$$$$$$",
            "                      $$$$          $$$$$$",
            "                      $$$$           $$$$$$",
            "$$$$$$$            $$$$          $$$$$$$",
            " $$$$$$            $$$$          $$$$$$$",
            "  $$$$$$$          $$$$        $$$$$$$$",
            "   $$$$$$$$       $$$$      $$$$$$$$",
            "      $$$$$$$$$$$$$$$$$$$$$$$$",
            "          $$$$$$$$$$$$$$$$$$$",
            "                  $$$$$$$$"
          }, xc - 65, yc + 15, angle, ConsoleColor.DarkBlue){ ShowLabel = show_label };
          dollars.Draw(painter);
        }

        // ship
        var ship = new Sprite(new List<IPixel> {
          new CharPixel('█', xc + offsetX + 4, yc + offsetY - 0, ConsoleColor.Red),
          new CharPixel('█', xc + offsetX + 3, yc + offsetY - 1, ConsoleColor.Red),
          new CharPixel('█', xc + offsetX + 2, yc + offsetY - 2, ConsoleColor.Red),
          new CharPixel('█', xc + offsetX + 1, yc + offsetY - 3, ConsoleColor.Red),
          new CharPixel('█', xc + offsetX + 0, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 1, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 2, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 3, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 4, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 5, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 6, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 7, yc + offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', xc + offsetX + 5, yc + offsetY - 1, ConsoleColor.Blue),
          new CharPixel('█', xc + offsetX + 6, yc + offsetY - 2, ConsoleColor.Blue),
          new CharPixel('█', xc + offsetX + 7, yc + offsetY - 3, ConsoleColor.Blue),
          new CharPixel('█', xc + offsetX + 8, yc + offsetY - 4, ConsoleColor.Blue),
        }, angle_ship, ConsoleColor.Yellow){ ShowLabel = show_label };
        //ship.Draw(painter);

        // ArchUser
        var up = new CharSprite(new [] {
          "              +              ",
          "              # ",
          "             ###       ",
          "            #####    ",
          "            ######    ",
          "           ; #####; ",
          "          +##.##### ",
          "         +##########         ",
          "        ######     ##;  ",
          "       ###            +      ",
          "      #                 ",
          "                             ",
          "                             ",
          "                             ",
          "                             ",
          "                             ",
          "                             ",
          "                             "
        }, 4, 4, angle_ship, ConsoleColor.Magenta){ ShowLabel = show_label };
        var down = new CharSprite(new [] {
          "                             ",
          "                ",
          "                       ",
          "                     ",
          "                      ",
          "                    ",
          "                    ",
          "                             ",
          "              #####     ",
          "          ############       ",
          "       ######   ####### ",
          "    .######;     ;###;`\".   ",
          "   .#######;     ;#####.     ",
          "   #########.   .########`   ",
          "  ######'           '######  ",
          " ;####                 ####; ",
          " ##'                     '## ",
          "#'                         `#"
        }, 4, 4, angle_ship, ConsoleColor.DarkMagenta){ ShowLabel = show_label };
        //up.Draw(painter);
        //down.Draw(painter);
        var sp = new Sprite(null, angle_ship){ ShowLabel = false };
        sp.Add(up);
        sp.Add(down);
        sp.Add(ship);
//        sp.Add(new CharPixel('╬', 0, 0, ConsoleColor.Red));
//        sp.Add(new CharPixel('╬', 5, 0, ConsoleColor.Green));
//        sp.Add(new CharPixel('╬', -5, 0, ConsoleColor.DarkBlue));
//        sp.Add(new CharSprite(new []{ "╔╗", "╚╝" }, -10, 0, angle, ConsoleColor.Yellow){ ShowLabel = show_label }); 
//        sp.Add(new CharPixel('╔', 10, 0, ConsoleColor.Yellow));
//        sp.Add(new CharPixel('╗', 11, 0, ConsoleColor.Yellow));
//        sp.Add(new CharPixel('╚', 10, -1, ConsoleColor.Yellow));
//        sp.Add(new CharPixel('╝', 11, -1, ConsoleColor.Yellow));
        sp.Draw(painter);

      } else {
        // INTEL LOGO
        var intel = new CharSprite(new[] { 
          "            ,_88888888888888888888888888888888888888_",
          "                 _88888888888~~~~~~        ~~~~~~~88888888888",
          "             ,g8888888~`                g8.             ~888!",
          "            _88888~        i8!          88!          __     '`",
          "          _888~           _d8bg88.      88!          888888_.",
          "        ,888`          -888888888`      88!          8888888888.",
          "       g88`    i88      88888!  ,88888  88!          888888888888.",
          "      d8P      '88 i88g8.  88` ,88~_88  88`               '8888888.",
          "     888       ,8  888888  88  888888`  88                   '88888i",
          "    d8P        88! d8! 88  88  88P~     88                     '8888.",
          "   i88         88  88  88  88  88b_88i  88                       8888",
          "   d8!         88  88  88  88  '88888   88          88i           888i",
          "   88          88  88  88  88     ,                 88!           '88!",
          "   8!          88  '~             88                88!            88!",
          "   8b                          __d88888i   ,88      88!   ,__      88!",
          "   88                         888888888`   888   ,g888! g88888     88!",
          "   88i                        88~88!  ,g8i      g88888!i88L888     88`",
          "   '88                        ,_ 88! 88888 88i d888888`888888     d88",
          "    88b            g8888i 88  88 88!888|   88` 88! 888 88P       g88`",
          "     888          ,88~~88 88  88 d8  8888  88 888.,888 888g88!  g88!",
          "      888.        88!  88!88  88 88    88! 88 '8888888  8888` ,d88!",
          "       8888       !88  88`88b888 88 88888` 88  '~~` 88       g888`",
          "        '8888.     888888 !88888 88 8888                  ,g8888",
          "          ~8888_    '88~   '~                          ,g88888`",
          "            ~888888_                                _8888888`",
          "              '88888888__.                    __g88888888~",
          "                 '~888888888888888____8888888888888888~",
          "                     '~888888888888888888888888888~",
          "                            ~~~8888888888~~~`"
        }, xc - 35, yc + 15, angle, ConsoleColor.DarkBlue){ ShowLabel = false };
        intel.Draw(painter);
      }

      // TODO: calc Total Pixels using visitor
      var total = 0;

      Console.SetCursorPosition(0, Console.WindowHeight - 2);
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("Zoom: {0:F2} angle: {1} stars: {4} C=[{2:F2}:{3:F2}]\nd1={6:F2} d2={7:F2} t1={8} t1={9}\nTotal pixels: {5}", ConsoleScreen.Zoom, (int) (angle / Math.PI * 180), xc, yc, asteriks_count, total, d1, d2, timer1, timer2);
    }
  }
}
