using Content.Shared._CitadelStation.WoundMed.Events;
using Content.Shared._CitadelStation.WoundMed.Components;

namespace Content.Server._CitadelStation.Woundmed.Systems;


public sealed class TargetingSystem : EntitySystem
{
    [Dependency] private readonly IEntityManager _entManager = default!;
    public override void Initialize(){
        base.Initialize();
        SubscribeNetworkEvent<BodypartTargetChangeEvent>(OnBodypartTargetChange);
    }

    private void OnBodypartTargetChange(BodypartTargetChangeEvent ev)
    {
        var user = GetEntity(ev.Uid);
        if(_entManager.GetComponent<BodypartTargetingComponent>(user) is not { } bodypartTargetingComponent
            || ev.Bodypart == bodypartTargetingComponent.chosenBodyPart) {
            return;
        }
        bodypartTargetingComponent.chosenBodyPart = ev.Bodypart;
        Logger.Debug($"Someone changed targetbodypart {ev.Uid} - {ev.Bodypart}");
        Dirty(GetEntity(ev.Uid),bodypartTargetingComponent);
    }
}
