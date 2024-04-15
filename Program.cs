using CreateXMI.Helper;
using CreateXMI.Helpers;
using CreateXMI.Models;
using System.Xml.Serialization;

namespace CreateXMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model = XmiModelBuilder.CreateModel();
            var extensions = new List<XmiExtension>
            {
                XmiExtensionBuilder.CreateMagicDraw2022Extension(),
                XmiExtensionBuilder.CreateMagicDraw2023Extension(),
            };

            XMI xmi = new XMI
            {
                Documentation = new Documentation
                {
                    Exporter = "MagicDraw UML",
                    ExporterVersion = "2022x v7"
                },
                Model = model,
                Extensions = extensions,
            };

            string xmlContent = SerializationHelper.SerializeObjectToXml(xmi);
            Console.WriteLine(xmlContent);
            File.WriteAllText("BDDtest.xml", xmlContent);
        }

      
    }
}
