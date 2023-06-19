using UnoMaestroLib.StackEngines;

namespace UnoMaestroLib;

public class Game
{
    private readonly Deck _deck = Deck.NewlyShuffled();

    private readonly DiscardPile _discardPile = new();
    private readonly ReversibleRing<Player> _players;

    private readonly IStackEngine _stackEngine;

    private RoundCondition _roundCondition = RoundCondition.Normal;

    private uint _stackCount;

    public Game(IEnumerable<Player> players, Rules rules)
    {
        _players = new ReversibleRing<Player>(players);
        _stackEngine = StackEngineFactory.CreateStackEngine(rules.PlusStackingConvention);
    }

    private void ShuffleDiscardPileIntoDeck()
    {
        GameServant.Rebalance(_deck, _discardPile);
        if (_deck.Empty) throw new InvalidUnoStateException("Deck empty after rebalance");
    }

    private void DealNCardsToPlayer(uint n, Player player)
    {
        for (var _ = 0; _ < n; _++)
        {
            var card = _deck.Pop()!;
            player.Hand.Add(card);
        }
    }

    public void PlayUntilCompletion()
    {
        while (PlayOneRound().RoundResult is not RoundResult.Victory) {}
    }


    public RoundOutcome PlayOneRound()
    {
        var player = _players.Next();

        RoundOutcome CreateRoundOutcome(RoundResult roundResult)
        {
            if (player is null) throw new InvalidUnoStateException("Player has become null");
            return new RoundOutcome(player, roundResult);
        }

        var top = _discardPile.Top;
        var result = player.Play(top, _roundCondition);
        if (_roundCondition is RoundCondition.PlusStack)
        {
            if (result is null)
            {
                if (_deck.Count <= _stackCount) ShuffleDiscardPileIntoDeck();
                DealNCardsToPlayer(_stackCount, player);
                _roundCondition = RoundCondition.Normal;
                return CreateRoundOutcome(player.Hand.Count is 0 ? RoundResult.Victory : RoundResult.PlusStackEnded);
            }
            _stackCount += result.PlusStackCount;
            _discardPile.Push(result);
            return CreateRoundOutcome(RoundResult.PlusStackContinued);
        }
        if (result is null)
        {
            if (_deck.Empty) ShuffleDiscardPileIntoDeck();
            DealNCardsToPlayer(1, player);
            return CreateRoundOutcome(RoundResult.NormalFailure);
        }
        _discardPile.Push(result);
        if (result.IsPlus)
        {
            _roundCondition = RoundCondition.PlusStack;
        }
        return CreateRoundOutcome(player.Hand.Count is 0 ? RoundResult.Victory : RoundResult.NormalSuccess);
    }
}