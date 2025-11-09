using Content.Shared._CitadelStation.WoundMed.Events;

namespace Content.Server._CitadelStation.Woundmed.Systems;


public sealed class TargetingSystem : EntitySystem
{
    public override void Initialize(){
        base.Initialize();
        SubscribeNetworkEvent<BodypartTargetChangeEvent>(OnBodypartTargetChange);
    }

    private void OnBodypartTargetChange(BodypartTargetChangeEvent ev)
    {
        Logger.Debug($"Someone changed targetbodypart {ev.Uid} - {ev.Bodypart}");
    }
}
