using Godot;

namespace MultipleProjectTest;

public partial class Root : Node
{
	[Export] private ContextToAttach _context;

	public override void _Ready()
	{
		_context.ToLogic().Initialize();
	}
}
