namespace interactive_tutorial.Service
{
    public interface ISerializeType
    {
        void Serialize(Type type, ISerialize obj);

        ISerialize Deserialize(Type type, ISerialize obj);
    }
}
