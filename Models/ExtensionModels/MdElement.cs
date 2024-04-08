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

        [XmlElement("geometry")]
        public string Geometry { get; set; }

        [XmlElement("text")]
        public string Text { get; set; }

        [XmlElement("mdOwnedViews")]
        public MdOwnedViews MdOwnedViews { get; set; }  // 假设mdOwnedViews也有特定的结构

        [XmlElement("symbolStyleID")]
        public string SymbolStyleId { get; set; }

        // Additional elements specific to the 'Association' elementClass
        [XmlElement("linkFirstEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID LinkFirstEndId { get; set; }

        [XmlElement("linkSecondEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID LinkSecondEndId { get; set; }

        [XmlElement("compartment")]
        public List<Compartment> Compartments { get; set; }

        [XmlElement("nameVisible")]
        public NameVisible NameVisible { get; set; }

        [XmlElement("associationFirstEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID AssociationFirstEndId { get; set; }

        [XmlElement("associationSecondEndID", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public ElementID AssociationSecondEndId { get; set; }

        // ... other properties as needed

        [XmlElement("roleNameID")]
        public ElementID RoleNameID { get; set; }
    }

}
