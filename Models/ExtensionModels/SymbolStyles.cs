using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models.ExtensionModels
{
    public class SymbolStyles
    {
        [XmlElement("mdElement")]
        public List<MdElement> MdElements { get; set; } = new List<MdElement>();


    }
}
