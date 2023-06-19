using System.Xml.Serialization;

namespace UnoMaestroLib.XmlPlugin;

public class PluginDeserializer
{
    public static Node Deserialize(string filepath)
    {
        var serializer = new XmlSerializer(typeof(Strategy));
        using (var reader = new StreamReader(filepath))
        {
            if (serializer.Deserialize(reader) is not Strategy deserialized)
            {
                throw new Exception("Xml file is not a strategy");
            }
            BuildTree(deserialized);
            return deserialized;
        }
    }

    private static void BuildTree(Node node)
    {
        foreach (var child in node.Children)
        {
            BuildTree(child);
        }
    }

    private static void Optimize(Node node)
    {
        if (node is Branch branch && branch.True)
    }
}