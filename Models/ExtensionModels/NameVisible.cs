using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models.ExtensionModels
{
    public class NameVisible
    {
        [XmlAttribute("value", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public bool Value { get; set; }
    }
}
