using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class PackagedElement
    {
        [XmlAttribute("type", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Type { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        public MemberEnd[] MemberEnds { get; set; }

        public OwnedEnd OwnedEnd { get; set; }

        public OwnedAttribute OwnedAttributes { get; set; }

    }

}
