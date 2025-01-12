using Robust.Shared.GameStates;

namespace Content.Shared._CorvaxNext.Surgery.Tools;

[RegisterComponent, NetworkedComponent]
public sealed partial class SurgicalDrillComponent : Component, ISurgeryToolComponent
{
    public string ToolName => "a surgical drill";
    public bool? Used { get; set; } = null;
}
