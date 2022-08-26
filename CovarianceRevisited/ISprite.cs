using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited
{
    public interface ISprite<out TShape> where TShape : Shape
    {
        Rect BoundingBox { get; }
        Point Location { get; }
        TShape Shape { get; }
    }
}