using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class OwnedDiagram : Attribute
    {
        //[XmlAttribute("xmi:type")]
        //public string Type { get; set; }

        //[XmlAttribute("xmi:id")]
        //public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("visibility")]
        public string Visibility { get; set; }

        [XmlAttribute("ownerOfDiagram")]
        public string OwnerOfDiagram { get; set; }

        [XmlElement("Extension", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public XmiExtension XmiExtension { get; set; }
    }

}
