using CreateXMI.Models.ExtensionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateXMI.Factories
{
    public static class MdOwnedViewsFactories
    {
        public static  MdOwnedViews CreateClassMdOwnedViews(string elementClass,string xmiId ,string elementId ,string geometry ,string symbolStyleId,string text)
        {
            // 创建并填充MdOwnedViews及其MdElements列表
            return new MdOwnedViews
            {
                MdElements = new List<MdElement>
            {
                new MdElement
                {
                    ElementClass = elementClass,
                    XmiId = xmiId,
                    ElementID = new ElementID { IdRef = elementId },
                    Geometry = geometry,
                    SymbolStyleId = symbolStyleId,
                    Text=text,
                    MdOwnedViews = new MdOwnedViews() 
                },
                // 可以添加更多的MdElement对象
            }
            };
        }
    }
}
