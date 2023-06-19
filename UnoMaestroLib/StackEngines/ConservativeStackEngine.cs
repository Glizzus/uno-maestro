namespace UnoMaestroLib.StackEngines;

public class ConservativeStackEngine : IStackEngine
{
    public PlusStackingConvention PlusStackingConvention => PlusStackingConvention.Conservative;

    public bool TestNormal(Card stacker, Card target)
    {
        return stacker.ColorMatches(target) || stacker.Color is Color.Undecided || stacker.FaceMatches(target);
    }

    public bool TestPlusStack(Card stacker, Card target)
    {
        return stacker.Face == target.Face || stacker.Face is Face.PlusFour;
    }
}