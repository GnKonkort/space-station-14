
using Robust.Shared.GameStates;
using Content.Shared._CitadelStation.WoundMed.Constants;

namespace Content.Shared._CitadelStation.WoundMed.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public partial class BodypartTargetingComponent : Component {
    [ViewVariables, AutoNetworkedField]
    public TargetChooserBodyPart chosenBodyPart = TargetChooserBodyPart.body;
}
