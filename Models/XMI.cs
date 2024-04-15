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
            // UML and XMI base namespaces
            Xmlns.Add("uml", "http://www.omg.org/spec/UML/20131001");
            Xmlns.Add("xmi", "http://www.omg.org/spec/XMI/20131001");

            // MagicDraw specific namespaces
            Xmlns.Add("DSL_Customization", "http://www.magicdraw.com/schemas/DSL_Customization.xmi");
            Xmlns.Add("MagicDraw_Profile", "http://www.omg.org/spec/UML/20131001/MagicDrawProfile");
            Xmlns.Add("Validation_Profile", "http://www.magicdraw.com/schemas/Validation_Profile.xmi");
            Xmlns.Add("StandardProfile", "http://www.omg.org/spec/UML/20131001/StandardProfile");

            // Additional MagicDraw customizations for UML and SysML
            Xmlns.Add("MD_Customization_for_Requirements__additional_stereotypes", "http://www.magicdraw.com/spec/Customization/180/Requirements");
            Xmlns.Add("MD_Customization_for_SysML__additional_stereotypes", "http://www.magicdraw.com/spec/Customization/180/SysML");

            // SysML namespace
            Xmlns.Add("sysml", "http://www.omg.org/spec/SysML/20181001/SysML");

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
