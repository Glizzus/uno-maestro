namespace UnoMaestroLib;

public static class ListExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        for (var i = list.Count - 1; i > 0; i--)
        {
            var k = Random.Shared.Next(i + 1);
            (list[k], list[i]) = (list[i], list[k]);
        }
    }
}