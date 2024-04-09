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
        public XmlSerializerNamespaces Xmlns { get; set; }
        public XMI()
        {
            Xmlns = new XmlSerializerNamespaces();
            Xmlns.Add("uml", "http://www.omg.org/spec/UML/20131001");
            Xmlns.Add("xmi", "http://www.omg.org/spec/XMI/20131001");
            // 添加其他必要的命名空间
        }
        [XmlElement(ElementName = "Documentation", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public Documentation Documentation { get; set; }
        [XmlElement("Model")]
        public Model Model { get; set; }
        [XmlArray("Extensions")]
        [XmlArrayItem("Extension", typeof(XmiExtension))]
        public List<XmiExtension> Extensions { get; set; } = new List<XmiExtension>(); // 初始化为避免null值

      
    }


}
