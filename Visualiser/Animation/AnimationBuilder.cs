namespace Visualiser.Animation;

public class AnimationBuilder
{
    private readonly List<AnimationFrame> _steps = [];

    public void AddStep(AnimationFrame frame)
    {
        _steps.Add(frame);
    }

    public void Change<T>(string id, Action<T> change) where T : AnimationObject
    {
        AnimationFrame newStep = _steps[^1].Copy();
        T? target = (newStep.Get(id) ?? throw new InvalidOperationException("Object not in Frame")) as T;
        change(target!);
        _steps.Add(newStep);
    }
}