namespace UnoMaestroLib.StackEngines;

public interface IStackEngine
{
    public PlusStackingConvention PlusStackingConvention { get; }
    public bool TestNormal(Card stacker, Card target);
    public bool TestPlusStack(Card stacker, Card target);
}