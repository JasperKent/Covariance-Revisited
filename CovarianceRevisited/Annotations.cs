using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited
{
    public class Annotations
    {
        private readonly List<ISprite<Shape>> _sprites = new();

        public void Add(ISprite<Shape> sprite) => _sprites.Add(sprite);

        public IEnumerable<ISprite<Shape>> GetSelected(Rect selectionBox)
        {
            return _sprites.Where(s => selectionBox.Contains(s.BoundingBox));
        }
    }
}
