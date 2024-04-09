using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models.ExtensionModels
{
    public class FilePart
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("header")]
        public string Header { get; set; }

        [XmlElement("mdOwnedViews")]
        public MdOwnedViews MdOwnedViews { get; set; }

        [XmlElement("mdElement")]
        public MdElement MdElement { get; set; }

        [XmlElement("symbolStyles")]
        public SymbolStyles SymbolStyles { get; set; }

    }
}
