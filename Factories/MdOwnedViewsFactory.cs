using CreateXMI.Models.ExtensionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateXMI.Factories
{
    public static class MdOwnedViewsFactory
    {
        public static MdOwnedViews CreateMdOwnedViews()
        {
            // 创建并填充MdOwnedViews及其MdElements列表
            return new MdOwnedViews
            {
                MdElements = new List<MdElement>
            {
                new MdElement
                {
                    ElementClass = "DiagramFrame",
                    XmiId = "_2022x_29f014a_1711420193749_997071_3229",
                    ElementID = new ElementID { IdRef = "_2022x_29f014a_1711420193669_817658_3212" },
                    Geometry = "5, 5, 885, 617",
                    SymbolStyleId = "_16_8beta_2104050f_1268298873363_492268_7965",
                    MdOwnedViews = new MdOwnedViews() // 初始化为一个空的MdOwnedViews对象
                },
                // 可以添加更多的MdElement对象
            }
            };
        }
    }
}
