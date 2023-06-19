// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using UnoMaestroLib.XmlPlugin;

string path = "C:\\Users\\Glizzus\\Projects\\UnoMaestro\\UnoMaestroLib\\Template.xml";
var serializer = new XmlSerializer(typeof(Strategy));
using (var reader = new StreamReader(path))
{
    var deserialized = serializer.Deserialize(reader) as Strategy;
    Console.WriteLine(deserialized);
    
}