using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class Attribute
    {
        [XmlAttribute("type", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string XmiType { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string XmiId { get; set; }

    }

}
