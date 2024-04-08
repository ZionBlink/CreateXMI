using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class Model
    {
        [XmlAttribute("type", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Type { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("ownedComment", Namespace = "")]
        //[XmlElement]
        public OwnedComment ownedComment { get; set; }

        [XmlElement("packagedElement", Namespace = "")]
        //[XmlElement]
        public PackagedElement[] packagedElements { get; set; }

        [XmlElement("profileApplication", Namespace = "")]
        public ProfileApplication profileApplication { get; set; }

        [XmlElement("Extension", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public XmiExtension xmiExtension { get; set; }

    }
}
