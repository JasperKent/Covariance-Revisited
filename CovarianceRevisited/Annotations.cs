using System.Windows;

namespace CovarianceRevisited
{
    public class Annotations
    {
        private readonly List<Sprite> _sprites = new();

        public void Add(Sprite sprite) => _sprites.Add(sprite);

        public IEnumerable<Sprite> GetSelected(Rect selectionBox)
        {
            return _sprites.Where(s => selectionBox.Contains(s.BoundingBox));
        }
    }
}
