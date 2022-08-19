using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited.Tests
{
    public class SelectionTests
    {
        private static Annotations GetAnnotations()
        {
            Annotations annotations = new Annotations();

            var shape1 = new Polyline();

            shape1.Points.Add(new Point(0, -10));
            shape1.Points.Add(new Point(5, 5));
            shape1.Points.Add(new Point(-5, 5));

            annotations.Add(new PolylineSprite(shape1, new Point(50, 50)));

            var shape2 = new Rectangle
            {
                Width = 10,
                Height = 15
            };

            annotations.Add(new RectangleSprite(shape2, new Point(80, 50)));

            var shape3 = new Polyline();

            shape3.Points.Add(new Point(-20, -20));
            shape3.Points.Add(new Point(4, 4));

            annotations.Add(new PolylineSprite(shape3, new Point(100, 20)));

            return annotations;
        }

        [StaFact]
        public void MatchesNone()
        {
            var selectionBox = new Rect(0, 0, 3, 4);

            var matches = GetAnnotations().GetSelected(selectionBox);

            Assert.Empty(matches);
        }

        [StaFact]
        public void MatchesAll()
        {
            var selectionBox = new Rect(0, 0, 300, 400);

            var matches = GetAnnotations().GetSelected(selectionBox);

            Assert.Collection(matches,
                s => Assert.IsType<PolylineSprite>(s),
                s => Assert.IsType<RectangleSprite>(s),
                s => Assert.IsType<PolylineSprite>(s)
                );
        }

        [StaFact]
        public void MatchesOne()
        {
            var selectionBox = new Rect(79, 49, 61, 66);

            var matches = GetAnnotations().GetSelected(selectionBox);

            Assert.Collection(matches,
                s => Assert.IsType<RectangleSprite>(s)
                );
        }
    }
}