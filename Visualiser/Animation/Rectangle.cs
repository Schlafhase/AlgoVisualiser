using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.Processing;

namespace Visualiser.Animation;

public class Rectangle : AnimationObject
{
    public (double Width, double Height) Dimensions { get; set; }
    public Pen Pen = new SolidPen(Color.Yellow);

    public override void Render(IImageProcessingContext ctx)
    {
        RectangularPolygon rect = new(new PointF((float)Position.X, (float)Position.Y), new PointF((float)Dimensions.Width, (float)Dimensions.Height));
        ctx.Draw(Pen, rect);
    }
}