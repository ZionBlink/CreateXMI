using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models.ExtensionModels
{
    public class ElementID
    {
        [XmlAttribute("idref", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string IdRef { get; set; }
    }
}
