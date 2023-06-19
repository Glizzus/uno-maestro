using System.Data;
using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public enum RoundCondition
{
   PlusStack,
   
}

public class RoundCondition
{
   private readonly string _conditionString;
   public RoundCondition(string conditionString)
   {
      _conditionString = conditionString;
   }

   public Func<UnoMaestroLib.RoundCondition, bool> ToFunction()
   {
      return _conditionString switch
      {
         "plus-stack" => roundCondition => roundCondition is UnoMaestroLib.RoundCondition.PlusStack,
         // TODO: Detail the exception
         _ => throw new Exception()
      };
   }


}