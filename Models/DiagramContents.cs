using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class DiagramContents
    {
        [XmlAttribute("contentHash")]
        public string ContentHash { get; set; }

        [XmlAttribute("exporterName")]
        public string ExporterName { get; set; }

        [XmlAttribute("exporterVersion")]
        public string ExporterVersion { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Id { get; set; }

        [XmlElement("binaryObject")]
        public BinaryObject BinaryObject { get; set; }

        [XmlElement("usedObjects")]
        public UsedObjects[] UsedObjects { get; set; }

        [XmlElement("usedElements")]
        public UsedElements[] UsedElements { get; set; }
    }
}
