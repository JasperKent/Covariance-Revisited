using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited
{
    public class PolylineSprite : Sprite
    {
        public PolylineSprite(Polyline shape, Point location) 
            : base(shape, location)
        {
        }

        public override Rect BoundingBox
        {
            get
            {
                double top = 0;
                double bottom = 0;
                double left = 0;
                double right = 0;

                foreach (Point p in ((Polyline)Shape).Points)
                {
                    top = Math.Min(top, p.Y);
                    bottom = Math.Max(bottom, p.Y);
                    left = Math.Min(left, p.X);
                    right = Math.Max(right, p.X);
                }

                return new Rect(left + Location.X, top + Location.Y, right - left, bottom - top);
            }
        }
    }
}
