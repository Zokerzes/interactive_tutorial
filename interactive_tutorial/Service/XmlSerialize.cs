using System.Xml.Serialization;

namespace interactive_tutorial.Service
{
    public class XmlSerialize : ISerializeType
    {
        XmlSerializer serializer;

        public ISerialize Deserialize(Type type, ISerialize obj)
        {
            serializer = new XmlSerializer(type);

            using FileStream fs = new($"{obj.FileName}.xml", FileMode.Create);

            return (ISerialize)serializer.Deserialize(fs);
        }

        public void Serialize(Type type, ISerialize obj)
        {
            serializer = new XmlSerializer(type);

            using FileStream fs = new($"{obj.FileName}", FileMode.Open);

            serializer.Serialize(fs, obj);
        }
    }
}
