namespace UnoMaestroLib.XmlPlugin;

public class HandCondition
{
    private readonly string _handConditionString;

    public HandCondition(string handConditionString)
    {
        _handConditionString = handConditionString;
    }

    public Func<int, bool> ToFunction()
    {
        var op = _handConditionString[0];
        var rhs = int.Parse(_handConditionString[1..]);
        
        return op switch
        {
            '>' => num => num > rhs,
            '<' => num => num < rhs,
            '=' => num => num == rhs,
            // TODO: details
            _ => throw new Exception()
        };
    }
}