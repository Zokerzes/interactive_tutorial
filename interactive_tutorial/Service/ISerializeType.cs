using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.Service
{
    public interface ISerializeType
    {
        void Serialize(Type type, ISerialize obj);
        ISerialize Deserialize(Type type, ISerialize obj);
    }
}
