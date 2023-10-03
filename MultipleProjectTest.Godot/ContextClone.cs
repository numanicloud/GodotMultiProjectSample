using Godot;

namespace MultipleProjectTest;

public partial class ContextClone : Sprite2D
{
    [Export] public Sprite2D Sprite { get; private set; }
}