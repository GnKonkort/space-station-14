namespace Content.Shared._CitadelStation.WoundMed.Constants;

[Flags]
public enum TargetChooserBodyPart : ushort
{
    head = 1,
    larm = 1 << 1,
    body = 1 << 2,
    rarm = 1 << 3,
    groin = 1 << 4,
    lleg = 1 << 5,
    rleg = 1 << 6
}
