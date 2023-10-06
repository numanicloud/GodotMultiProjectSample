using System.Reactive;
using Godot;

namespace ClassLibrary1;

public class Context
{
    public required Sprite2D Sprite { get; init; }
    public required IObservable<Unit> OnProcess { get; init; }

    public void Initialize()
    {
        OnProcess.Subscribe(_ => Sprite.Position += Vector2.Down * 10);
    }
}