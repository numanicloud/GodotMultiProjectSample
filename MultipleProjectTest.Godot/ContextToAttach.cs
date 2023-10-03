using System;
using System.Reactive;
using System.Reactive.Subjects;
using ClassLibrary1;
using Godot;

namespace MultipleProjectTest;

public partial class ContextToAttach : Sprite2D
{
    [Export] public Sprite2D Sprite { get; private set; }

    private readonly Subject<Unit> _onProcess = new();
    public IObservable<Unit> OnProcess => _onProcess;
    
    public override void _Process(double delta)
    {
        _onProcess.OnNext(Unit.Default);
    }

    public Context ToLogic()
    {
        return new Context()
        {
            Sprite = Sprite,
            OnProcess = OnProcess
        };
    }
}