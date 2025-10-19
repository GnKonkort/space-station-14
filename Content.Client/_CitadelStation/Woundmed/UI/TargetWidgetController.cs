using Content.Client.Gameplay;
using Robust.Client.UserInterface.Controllers;
using Robust.Client.Player;
using Content.Client.Gameplay;
using Content.Client._CitadelStation.Woundmed.Systems;

namespace Content.Client._CitadelStation.Woundmed.UI;
public sealed class TargetWidgetController : UIController, IOnStateEntered<GameplayState>, IOnSystemChanged<TargetingSystem>
{
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
}
