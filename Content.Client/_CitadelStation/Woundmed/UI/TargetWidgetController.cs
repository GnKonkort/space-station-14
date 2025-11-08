using Content.Client.Gameplay;
using Robust.Client.UserInterface.Controllers;
using Content.Client._CitadelStation.Woundmed.Systems;
using Content.Client.UserInterface.Systems.Gameplay;
using Robust.Client.UserInterface;
using Content.Shared._CitadelStation.WoundMed.Constants;
using Robust.Client.Player;
using Content.Shared._CitadelStation.WoundMed.Events;
using Content.Shared.Actions.Components;
using Content.Shared._CitadelStation.WoundMed.Components;

namespace Content.Client._CitadelStation.Woundmed.UI;
public sealed class TargetWidgetController : UIController, IOnStateEntered<GameplayState>, IOnSystemChanged<TargetingSystem>
{
    // Dependency is used for IoC services and other controllers
    [Dependency] private readonly GameplayStateLoadController _gameplayStateLoad = default!;
    [UISystemDependency] private readonly TargetingSystem _targetingSystem = default!;

    [Dependency] private readonly IEntityManager _entManager = default!;
    [Dependency] private readonly IEntityNetworkManager _net = default!;
    [Dependency] private readonly IPlayerManager _playerManager = default!;

    private BodypartTargetChangeEvent BodypartTargetChangeNetMessage = default!;
    private TargetControl? TargetingControl => UIManager.GetActiveUIWidgetOrNull<TargetControl>();
    public override void Initialize()
    {
        base.Initialize();
    }

    public void OnStateEntered(GameplayState state)
    {
        //throw new NotImplementedException();
    }

    public void OnSystemLoaded(TargetingSystem system)
    {
        //throw new NotImplementedException();
    }

    public void OnSystemUnloaded(TargetingSystem system)
    {
        //throw new NotImplementedException();
    }
    public void OnChangingBodypartTarget (TargetChooserBodyPart bodypart){
        if (
            _playerManager.LocalEntity is not { } user ||
            _entManager.GetComponent<BodypartTargetingComponent>(user) is not { } bodypartTargetingComponent ||
            TargetingControl == null
        )
        {
            return;
        }

        var player = _entManager.GetNetEntity(user);

        if (bodypartTargetingComponent.chosenBodyPart != bodypart){
            BodypartTargetChangeNetMessage = new BodypartTargetChangeEvent(player, bodypart);
            _net.SendSystemNetworkMessage(BodypartTargetChangeNetMessage);
            bodypartTargetingComponent.chosenBodyPart = bodypart;
        }

    }
}
