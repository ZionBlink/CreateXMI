using CreateXMI.Models.ExtensionModels;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class XmiExtension
    {
        [XmlAttribute("extender")]
        public string Extender { get; set; }

        [XmlElement("referenceExtension", Namespace = "")]
        public ReferenceExtension ReferenceExtension { get; set; }

        [XmlElement("diagramRepresentation", Namespace = "")]
        public DiagramRepresentation DiagramRepresentation { get; set; }

        [XmlElement("modelExtension", Namespace = "")]
        public ModelExtension ModelExtension { get; set; }

        [XmlElement("filePart", Namespace = "")]
        public FilePart FilePart { get; set; }
    }
}
