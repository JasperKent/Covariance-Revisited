using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace CovarianceRevisited
{
    public class RectangleSprite : Sprite<Rectangle>
    {
        public RectangleSprite(Rectangle shape, Point location) 
            : base(shape, location)
        {
        }

        public override Rect BoundingBox
        {
            get
            {
                return new Rect (Location, new Size (Shape.Width, Shape.Height));
            }
        }
    }
}
