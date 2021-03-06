using System;

namespace Game
{
  class CharPixel:IPixel
  {
    public virtual double X { get; protected set; }
    public virtual double Y { get; protected set; }
    public ConsoleColor Color { get; }
    public virtual int Width { get { return 1; } }
    public virtual int Height { get { return 1; } }

    readonly char pixel;
    public char Value { get { return pixel; } }

    public CharPixel(char pixel = (char) 0, double x = 0, double y = 0, ConsoleColor color = ConsoleColor.White)
    {
      this.pixel = pixel;
      X = x;
      Y = y;
      Color = color;
    }

    public virtual void Move(double dx, double dy)
    {
      X += dx;
      Y += dy;
    }

    public virtual void Accept(IPixelVisitor visitor)
    {
      visitor.Visit(this);
    }

    public virtual void Draw(IPainter painter)
    {
      painter.Draw(this);
    }

    public void Set(double x, double y)
    {
      X = x;
      Y = y;
    }

    public IPixel Clone()
    {
      return new CharPixel(pixel, X, Y, Color);
    }
  }
}
