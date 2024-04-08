using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models.ExtensionModels
{
    public class Compartment
    {
        [XmlAttribute("compartmentID")]
        public string CompartmentId { get; set; }

        [XmlAttribute("isContentLocked")]
        public bool IsContentLocked { get; set; }
    }
}
