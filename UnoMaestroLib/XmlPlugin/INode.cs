namespace UnoMaestroLib.XmlPlugin;

public abstract class Node
{
   public void AddChild(Node child) => Children.Add(child);

   public void RemoveChild(Node child) => Children.Remove(child);

   public IList<Node> Children { get; } = new List<Node>();


}