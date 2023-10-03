using Godot;

namespace MultipleProjectTest;

public partial class Root : Node
{
	[Export] private ContextClone _contextClone;

	public override void _Process(double delta)
	{
		_contextClone.Sprite.Position += new Vector2(0, 10);
	}
}
