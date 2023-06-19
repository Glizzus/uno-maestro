namespace UnoMaestroLib.StackEngines;

public class LiberalStackEngine : IStackEngine
{
    public PlusStackingConvention PlusStackingConvention => PlusStackingConvention.Liberal;

    public bool TestNormal(Card stacker, Card target)
    {
        return stacker.ColorMatches(target) || stacker.Color is Color.Undecided || stacker.FaceMatches(target);
    }

    public bool TestPlusStack(Card stacker, Card target)
    {
        if (stacker.Face is Face.PlusTwo && target.Face is Face.PlusFour)
            return stacker.ColorMatches(target) || stacker.Color is Color.Undecided;
        return true;
    }
}