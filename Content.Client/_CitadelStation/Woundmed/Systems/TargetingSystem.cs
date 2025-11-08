using Content.Shared._CitadelStation.Woundmed.Systems;
using Content.Shared._CitadelStation.WoundMed.Constants;
using Content.Shared._CitadelStation.WoundMed.Events;
using Content.Shared._CitadelStation.WoundMed.Components;

namespace Content.Client._CitadelStation.Woundmed.Systems;

public sealed class TargetingSystem : SharedTargetingSystem
{
    [Dependency] private readonly ILogManager _logManager = default!;
    private readonly ISawmill _sawmill = default!;
    public event Action<TargetChooserBodyPart>? TargetChange;
    public TargetingSystem()
    {
        //_sawmill = _logManager.GetSawmill("testtesttest");
        //_sawmill.Log(LogLevel.Info, "TargetingSystem was successfully launched on client");
    }
    public void OnBodypartTargetChange(EntityUid uid, BodypartTargetingComponent component, TargetChooserBodyPart bodypart) {
        //_sawmill.Log(LogLevel.Info, "TargetingSystem was successfully launched on client");
        //_sawmill.Info("TargetingSystem was successfully launched on client");
    }
};
