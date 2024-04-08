using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class BinaryObject
    {
        [XmlAttribute("streamContentID")]
        public string StreamContentId { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/XMI")]
        public string Id { get; set; }

        [XmlAttribute("type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XsiType { get; set; }
    }
}
