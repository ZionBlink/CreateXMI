using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class OwnedEnd
    {
        [XmlAttribute("type", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Type { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Id { get; set; }

        [XmlAttribute("visibility")]
        public string Visibility { get; set; }

        [XmlAttribute("type")]
        public string TypeId { get; set; }

        [XmlAttribute("association")]
        public string AssociationId { get; set; }
    }
}
