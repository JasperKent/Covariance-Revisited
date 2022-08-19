
using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited
{
    public abstract class Sprite
    {
        public Sprite(Shape shape, Point location)
        {
            Shape = shape;
            Location = location;
        }

        public Shape Shape { get; }
        public Point Location { get; }
        public abstract Rect  BoundingBox { get; }
    }
}