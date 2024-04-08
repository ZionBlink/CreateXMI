using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class ModelExtension
    {
        [XmlElement("ownedDiagram")]
        public OwnedDiagram OwnedDiagram { get; set; }
    }

}
