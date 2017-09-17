using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manchkin_online
{
    [DataContract]
    class Meta
    {
        [DataMember]
        private int ID;

        [DataMember]
        private String Category;

        [DataMember]
        private String Type;

        [DataMember]
        private String Name;

        [DataMember]
        private String Class;

        [DataMember]
        private String Race;

        [DataMember]
        private int attack;

        [DataMember]
        private int level;

        [DataMember]
        private int action;
    }
}
