namespace Game
{
  interface IPixelVisitor
  {
    void Visit(IPixel pixel);
    void Visit(CharSprite sprite);
    void Visit(Sprite sprite);
  }
}
