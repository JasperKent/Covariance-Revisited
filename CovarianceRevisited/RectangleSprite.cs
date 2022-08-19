using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited
{
    public class RectangleSprite : Sprite
    {
        public RectangleSprite(Rectangle shape, Point location) 
            : base(shape, location)
        {
        }

        public override Rect BoundingBox
        {
            get
            {
                var asRect = (Rectangle)Shape;

                return new Rect (Location, new Size (asRect.Width, asRect.Height));
            }
        }
    }
}
