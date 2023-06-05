using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.Service
{
    public class SerializeService
    {
        public static void ObjSerialize(Type type, ISerialize obj, ISerializeType serialize)
        {
            serialize.Serialize(type, obj);
        }
        public static ISerialize ObjDeserialize(Type type, ISerialize obj, ISerializeType serialize)
        {
            return serialize.Deserialize(type, obj);
        }
    }
}
