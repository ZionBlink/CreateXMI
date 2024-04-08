using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class DiagramRepresentation
    {
        [XmlElement(ElementName = "DiagramRepresentationObject", Namespace = "http://www.nomagic.com/ns/magicdraw/core/diagram/1.0")]
        public DiagramRepresentationObject DiagramRepresentationObject { get; set; }
    }
}
