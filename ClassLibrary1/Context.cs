using Godot;

namespace ClassLibrary1;

public partial class Context : Sprite2D
{
    [Export] public Sprite2D Sprite { get; private set; }
    
    public override void _Process(double delta)
    {
        Sprite.Position += new Vector2(0, 10);
    }
}