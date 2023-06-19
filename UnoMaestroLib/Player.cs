namespace UnoMaestroLib;

public class Player
{
    public IList<Card> Hand = new List<Card>();

    public Player(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public Card? Play(Card target, RoundCondition condition)
    {
        throw new Exception();
    }
}