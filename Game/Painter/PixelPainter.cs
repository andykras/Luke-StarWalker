using System;
using Util;

namespace Game
{
  class PixelPainter:EmptyPainter
  {
    public override void Draw(CharPixel pixel)
    {
      ConsoleScreen.Draw(pixel.X, pixel.Y, pixel.Color, () => Console.Write(pixel.Value));
    }

    public override void Draw(Sprite sprite)
    {
      foreach (var pixel in sprite) {
        pixel.Draw(this);
      }
      ConsoleScreen.Draw(sprite.X + sprite.Width, sprite.Y, sprite.Color, () => Console.Write(sprite));
    }
  }
  
}
