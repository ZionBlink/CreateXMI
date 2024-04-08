using System.Xml.Serialization;

namespace CreateXMI.Models
{
    public class OwnedComment
    {
        [XmlAttribute("type", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Type { get; set; }
        // Continue with the rest of your model definitions...
        [XmlAttribute("id", Namespace = "http://www.omg.org/spec/XMI/20131001")]
        public string Id { get; set; }

        [XmlAttribute("body")]
        public string Body { get; set; }

        [XmlElement("annotatedElement")]
        public AnnotatedElement AnnotatedElement { get; set; }
    }

    
}
