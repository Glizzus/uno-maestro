namespace UnoMaestroLib.StackEngines;

public static class StackEngineFactory
{
    public static IStackEngine CreateStackEngine(PlusStackingConvention convention)
    {
        return convention switch
        {
            PlusStackingConvention.Banned => new BannedStackEngine(),
            PlusStackingConvention.Conservative => new ConservativeStackEngine(),
            PlusStackingConvention.Liberal => new LiberalStackEngine(),
            _ => throw new ArgumentException($"Invalid stacking convention: {nameof(convention)}")
        };
    }
}