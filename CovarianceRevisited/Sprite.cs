
using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited
{
    public abstract class Sprite<TShape> : ISprite<TShape> where TShape : Shape
    {
        public Sprite(TShape shape, Point location)
        {
            Shape = shape;
            Location = location;
        }

        public TShape Shape { get; }
        public Point Location { get; }
        public abstract Rect BoundingBox { get; }
    }
}