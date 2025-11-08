using Content.Shared._CitadelStation.WoundMed.Constants;
using Robust.Shared.Serialization;

namespace Content.Shared._CitadelStation.WoundMed.Events;

[Serializable, NetSerializable]
public sealed class BodypartTargetChangeEvent(NetEntity uid, TargetChooserBodyPart bodypart) : EntityEventArgs {
    public NetEntity Uid { get; } = uid;

    public TargetChooserBodyPart Bodypart { get; } = bodypart;
}
