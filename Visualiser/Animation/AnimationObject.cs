using SixLabors.ImageSharp.Processing;

namespace Visualiser.Animation;

public abstract class AnimationObject
{
    public required string Id { get; set; }
    public (double X, double Y) Position { get; set; }
    public (double Width, double Height) BoundingBox { get; set; }

    public abstract void Render(IImageProcessingContext ctx);
}