using System;
using System.Collections.Generic;
using Util;
using System.Linq;
using System.Net;

namespace Game
{
  public partial class Game
  {
    void Draw()
    {
      ConsoleScreen.Clear();
      var pixelList = new List<IPixel>();

      // Mario
      pixelList.Add(new CharSprite(ASCII.Mario, xc + 150, yc + 200, 0, ConsoleColor.Green){ ShowLabel = show_label });
      pixelList.Last().Draw(painter);

      // STARS
      var asteriks = new Sprite(null, angle, ConsoleColor.Yellow){ ShowLabel = show_label };
      for (var i = 0; i < asteriks_count; i++) asteriks.Add(new CharPixel('*', xc + random_numbers[2 * i], yc + random_numbers[2 * i + 1]));
      if (asteriks_count != 0) {
        asteriks.Draw(painter);
        pixelList.Add(asteriks);
      }

      // center of the universe
      pixelList.Add(new CharPixel('@', xc, yc, ConsoleColor.Yellow));
      pixelList.Last().Draw(pixel_painter);

      // Skull
      var ang = Math.PI / 512;
      for (var i = 0; i < 10; i++) {
        pixelList.Add(new CharSprite(ASCII.Skull, xc + 200 * Math.Cos((skull_index + 20 * random_numbers[2 * i]) * ang), yc + 200 * Math.Sin((skull_index + 20 * random_numbers[2 * i + 1]) * 2 * ang), 0, ConsoleColor.DarkGray){ ShowLabel = show_label });
        pixelList.Last().Draw(painter);
      }

      if (show_intel) {
        // INTEL LOGO
        var intel = new CharSprite(ASCII.IntelLogo, xc - 35, yc + 15, angle, ConsoleColor.DarkBlue){ ShowLabel = false };
        intel.Draw(painter);
        pixelList.Add(intel);
      } else {
        // CIRCLE
        if (show_circle) {
          var alpha = Math.PI * 2.0 / count;
          for (var i = 0; i < count; i++) {
            var x = xc + R * Math.Cos(i * alpha);
            var y = yc + R * Math.Sin(i * alpha);
            pixelList.Add(new CharPixel('█', x, y, (ConsoleColor) rnd.Next(1, 15)));
            pixelList.Last().Draw(pixel_painter);
          }

          var tet = new CharSprite(new [] { 
            " █ ",
            "███",
            "   " 
          }, xc - 3, yc + 3, angle){ ShowLabel = show_label };
          tet.Draw(painter);
          pixelList.Add(tet);
        }

        if (show_dollar) {
          var dollars = new CharSprite(ASCII.Dollar, xc - 135, yc + 15, angle, ConsoleColor.DarkBlue){ ShowLabel = show_label };
          dollars.Draw(painter);
          pixelList.Add(dollars);
        }

        // ship
        var ship = new Sprite(new List<IPixel> {
          new CharPixel('█', offsetX + 4, offsetY - 0, ConsoleColor.Red),
          new CharPixel('█', offsetX + 3, offsetY - 1, ConsoleColor.Red),
          new CharPixel('█', offsetX + 2, offsetY - 2, ConsoleColor.Red),
          new CharPixel('█', offsetX + 1, offsetY - 3, ConsoleColor.Red),
          new CharPixel('█', offsetX + 0, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 1, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 2, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 3, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 4, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 5, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 6, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 7, offsetY - 4, ConsoleColor.Green),
          new CharPixel('█', offsetX + 5, offsetY - 1, ConsoleColor.Blue),
          new CharPixel('█', offsetX + 6, offsetY - 2, ConsoleColor.Blue),
          new CharPixel('█', offsetX + 7, offsetY - 3, ConsoleColor.Blue),
          new CharPixel('█', offsetX + 8, offsetY - 4, ConsoleColor.Blue),
        }, angle_ship, ConsoleColor.Yellow){ ShowLabel = show_label };

        // ArchUser
        var up = new CharSprite(ASCII.ArchUserUp, -10, 0, angle_ship, ship_color){ ShowLabel = show_label };
        var down = new CharSprite(ASCII.ArchUserDown, -10, 0, angle_ship, ship_color - 8){ ShowLabel = show_label };

        pixelList.Add(new Sprite(new List<IPixel>{ up, down, ship }, angle_ship){ ShowLabel = false });
        pixelList.Last().Draw(painter);
      }

      var counter = new PixelCounter();
      pixelList.ForEach(p => p.Accept(counter));

      Console.ForegroundColor = ConsoleColor.Red;
      if (show_stat) {
        ConsoleScreen.Print(string.Format("Zoom: {0:F2} angle: {1} stars: {2} C=[{3:F2}:{4:F2}]", ConsoleScreen.Zoom, (int) (angle / Math.PI * 180), asteriks_count, xc, yc), 3);
        ConsoleScreen.Print(string.Format("d1={0:F2} d2={1:F2} t1={2} t2={3} t3={4}", d1, d2, timer1, timer2, timer3), 2);
        ConsoleScreen.Print(string.Format("Total pixels: {0}, Total sprites: {1}", counter.TotalCharPixels, counter.TotalCharSprites + counter.TotalSprites), 1);
      }
      if (show_help) {
        var text = new [] {
          "H - Toggle HELP",
          "E,S,D,F - Ship Movement",
          "-----------------------", " ", " ",
          "L - Show/Hide sprite Labels",
          "1-8 - Change Ship Color",
          "Num* (KP_Multiply) - Add 1 Star (Alt+* - Add 10 Stars)",
          "Num +/-, Num_Enter (KP_Enter) - Zoom, Reset Zoom",
          "Num/ (KP_Device) - Reset all to Defaults",
          "Alt + any_key - Speed Up",
          "C - Show/Hide Circle",
          "Insert/Delete - Add/Remove points to Circle",
          "Shift+4 ($) - Show/Hide Dollar",
          "W,R - miniShip Strafe",
          "Num8,Num5,Num4,Num6 - Scene Movement",
          "Num7,Num9 - Scene Rotation",
          "o,p,[,] - Timers",
          "Enter - Change Painters",
          "I - Show/Hide Intel Logo",
          "F1 - Toggle Stat",
        };
        ConsoleScreen.Print(text, true);
      }

      if (show_task) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        var task = "Find the Center (@) of the Universe";
        var len = Console.WindowWidth / 2 - task.Length / 2;
        task = new string(' ', len > 0 ? len : 0) + task;
        ConsoleScreen.Print(task, Console.WindowHeight / 2);
      }
    }
  }
}
