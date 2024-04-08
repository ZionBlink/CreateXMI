using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models.ExtensionModels
{
    public class TextBox
    {
        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string XmiId { get; set; }

        [XmlElement("elementID")]
        public ElementID ElementID { get; set; }

        [XmlElement("geometry")]
        public string Geometry { get; set; }

        [XmlElement("mdOwnedViews")]
        public MdOwnedViews MdOwnedViews { get; set; } // 假定它是递归定义的

        [XmlElement("text")]
        public string Text { get; set; }

        [XmlElement("symbolStyleID")]
        public string SymbolStyleId { get; set; }
    }
}
