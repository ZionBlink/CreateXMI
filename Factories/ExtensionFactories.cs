using CreateXMI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateXMI.Factories
{
    public static class ExtensionFactories
    {
        public static List<XmiExtension> CreateMagicDrawExtensions()
        {
            var extensions = new List<XmiExtension>();
            // 添加MagicDraw相关的extensions
            extensions.Add(new XmiExtension { Extender = "MagicDraw UML 2022x" });
            // 可以添加更多
            return extensions;
        }

        public static List<XmiExtension> CreateSysMLExtensions()
        {
            var extensions = new List<XmiExtension>();
            // 添加SysML相关的extensions
            extensions.Add(new XmiExtension { Extender = "SysML Plugin 2022x" });
            // 可以添加更多
            return extensions;
        }

        // ... 可以添加更多工厂方法以构造不同类别的Extensions
    }

}
