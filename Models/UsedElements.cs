using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class UsedElements
    {
        [XmlText]
        public string Value { get; set; }
    }

}
