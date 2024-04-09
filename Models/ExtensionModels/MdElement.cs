using System.Xml.Serialization;

namespace CreateXMI.Models.ExtensionModels
{
    [XmlType("mdElement")]
    public class MdElement
    {
        [XmlAttribute("elementClass")]
        public string ElementClass { get; set; }

        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string XmiId { get; set; }

        [XmlElement("elementID")]
        public ElementID ElementID { get; set; }  // 假设elementID也有特定的结构
                                                  // Additional elements specific to the 'Association' elementClass
        [XmlElement("linkFirstEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID LinkFirstEndId { get; set; }

        [XmlElement("linkSecondEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID LinkSecondEndId { get; set; }


        [XmlElement("geometry")]
        public string Geometry { get; set; }
        [XmlElement("compartment")]
        public List<Compartment> Compartments { get; set; }

        [XmlElement("nameVisible")]
        public NameVisible NameVisible { get; set; }

        [XmlElement("mdOwnedViews")]
        public MdOwnedViews MdOwnedViews { get; set; }
        [XmlElement("text")]
        public string Text { get; set; }


        [XmlElement("roleNameID")]
        public ElementID RoleNameID { get; set; }
        [XmlElement("associationFirstEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID AssociationFirstEndId { get; set; }

        [XmlElement("associationSecondEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID AssociationSecondEndId { get; set; }


        [XmlElement("symbolStyleID")]
        public string SymbolStyleId { get; set; }

        [XmlElement("stereotype")]
        public string Stereotype { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("propertyManagerID")]
        public string PropertyManagerID { get; set; }

        [XmlElement("parentPropertyManager")]
        public string ParentPropertyManager { get; set; }

        [XmlElement("propertyID")]
        public string PropertyID { get; set; }

        [XmlElement("value")]
        public Value Value { get; set; }
        [XmlElement("index")]
        public Value Index { get; set; }
        [XmlElement("fontName")]
        public string FontName { get; set; }
        [XmlElement("size")]
        public Value Size { get; set; }

        [XmlElement("mdElement")]
        public List<MdElement> MdElements { get; set; } = new List<MdElement>();

        [XmlElement("hiddenProperties")]
        public Value HiddenProperties { get; set; }
    }

}
