﻿using System;
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
        public string Value { get; set; } // 如果在其他地方是字符串，这里也应该是字符串
    }
}
