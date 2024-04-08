using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class Documentation
    {
        [XmlElement(ElementName = "exporter", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Exporter { get; set; }

        [XmlElement(ElementName = "exporterVersion", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string ExporterVersion { get; set; }
    }
}
