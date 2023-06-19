namespace UnoMaestroLib;

public class InvalidUnoStateException : Exception
{
    public InvalidUnoStateException()
    {
    }

    public InvalidUnoStateException(string message) : base(message)
    {
    }
}