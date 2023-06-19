namespace UnoMaestroLib.StackEngines;

public class BannedStackEngine : IStackEngine
{
    public PlusStackingConvention PlusStackingConvention => PlusStackingConvention.Banned;

    public bool TestNormal(Card stacker, Card target)
    {
        return stacker.ColorMatches(target) || stacker.Color is Color.Undecided || stacker.FaceMatches(target);
    }

    public bool TestPlusStack(Card stacker, Card target)
    {
        return false;
    }
}