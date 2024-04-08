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
            var sb = new StringBuilder();

            using (var writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, xmi, xmi.xmlns); // 使用xmi对象中定义的命名空间
            }

            return sb.ToString();
        }

    }
}
