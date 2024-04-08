using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXMI.Models
{
    [XmlRoot(ElementName = "XMI", Namespace = "http://www.omg.org/spec/XMI/20131001")]
    public class XMI
    {

        // 添加XmlSerializerNamespaces属性
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns { get; set; }
        public XMI()
        {
            xmlns = new XmlSerializerNamespaces();
            xmlns.Add("uml", "http://www.omg.org/spec/UML/20131001");
            xmlns.Add("xmi", "http://www.omg.org/spec/XMI/20131001");
            // 添加其他必要的命名空间
        }
        [XmlElement(ElementName = "Documentation", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public Documentation Documentation { get; set; }
        [XmlElement("model")]
        public Model model { get; set; }
        [XmlArray("Extensions")]
        [XmlArrayItem("Extension", typeof(XmiExtension))]
        public List<XmiExtension> Extensions { get; set; } = new List<XmiExtension>(); // 初始化为避免null值

      
    }


}
