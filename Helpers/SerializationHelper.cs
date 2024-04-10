using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using CreateXMI.Models;

namespace CreateXMI.Helper
{
    public static class SerializationHelper
    {
        public static string SerializeObjectToXml(XMI xmi)
        {
            var serializer = new XmlSerializer(typeof(XMI));
            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = false,
                Indent = true, // 根据需要设置
                Encoding = new UTF8Encoding(false) // 防止BOM的写入
            };

            var sb = new StringBuilder();

            // 使用XmlWriter创建XML，允许更多的控制
            using (var writer = XmlWriter.Create(sb, settings))
            {
                // 为XmlSerializer提供XmlSerializerNamespaces，如果已定义
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                

                serializer.Serialize(writer, xmi, namespaces);
            }

            return sb.ToString();
        }

    }
}
