using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class DiagramRepresentationObject
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns { get; set; }

        [XmlAttribute("ID")]
        public string ID { get; set; }

        [XmlAttribute("initialFrameSizeSet")]
        public string InitialFrameSizeSet { get; set; }

        [XmlAttribute("requiredFeature")]
        public string RequiredFeature { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("umlType")]
        public string UmlType { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Id { get; set; }

        [XmlAttribute("version", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string XmiVersion { get; set; }

        [XmlElement("diagramContents", Namespace = "")]
        public DiagramContents DiagramContents { get; set; }
    }
}
