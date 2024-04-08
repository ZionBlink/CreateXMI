using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class ReferenceExtension
    {
        [XmlAttribute("referentPath")]
        public string ReferentPath { get; set; }

        [XmlAttribute("referentType")]
        public string ReferentType { get; set; }

        [XmlAttribute("originalID")]
        public string OriginalId { get; set; }
    }
}
