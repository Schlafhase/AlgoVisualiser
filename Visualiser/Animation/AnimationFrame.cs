using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace Visualiser.Animation
{
    public class AnimationFrame(List<AnimationObject> objects)
    {
        private readonly List<AnimationObject> _objects = objects;

        public AnimationObject? Get(string id)
        {
            return _objects.Find(o => o.Id == id);
        }

        public void Add(AnimationObject obj)
        {
            if (_objects.Find(o => o.Id == obj.Id) is not null)
            {
                throw new InvalidOperationException("Id already in use");
            }

            _objects.Add(obj);
        }

        public AnimationFrame Copy()
        {
            return new AnimationFrame(_objects);
        }

        public Image<Rgba32> Render(int width, int height)
        {
            return render(_objects, width, height);

        }

        private static Image<Rgba32> render(List<AnimationObject> objs, int width, int height)
        {
            Image<Rgba32> img = new(width, height);

            img.Mutate(ctx =>
            {
                foreach (AnimationObject obj in objs)
                {
                    obj.Render(ctx);
                }
            });

            return img;
        }
    }
}