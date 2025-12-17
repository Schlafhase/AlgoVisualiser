using SixLabors.ImageSharp.Processing;

namespace Visualiser.Animation
{
    public class Rectangle : AnimationObject
    {
        public (double Width, double Height) Dimensions { get; set; }

        public override void Render(IImageProcessingContext ctx)
        {
            throw new NotImplementedException();
        }
    }
}
