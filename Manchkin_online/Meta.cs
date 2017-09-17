using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Manchkin_online
{
    [DataContract]
    class Meta
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Class { get; set; }

        [DataMember]
        public string Race { get; set; }

        [DataMember]
        public string Must { get; set; }

        [DataMember]
        public string Not_Must { get; set; }

        [DataMember]
        public int Attack { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public int Action { get; set; }

        [DataMember]
        public string Baff { get; set; }
    }
}
