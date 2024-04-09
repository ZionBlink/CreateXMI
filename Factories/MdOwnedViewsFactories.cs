using CreateXMI.Models.ExtensionModels;

namespace CreateXMI.Factories
{
    public static class MdOwnedViewsFactories
    {
        public static MdOwnedViews CreateMdOwnedViews()
        {
            var mdOwnedViews = new MdOwnedViews
            {
                MdElements = new List<MdElement> {
                    MdElementFactories.CreateDiagramFrameElement(),
                    MdElementFactories.CreateClassElement(
                    "Class",
                    "_2022x_29f014a_1711421319439_792255_3244",
                    "_2022x_29f014a_1711421319433_506189_3243",
                    "112, 77, 80, 33",
                    "_17_0_1_e9b034a_1316580179343_836214_11299"
                    ),
                     MdElementFactories.CreateClassElement(
                    "Class",
                    "_2022x_29f014a_1711421923724_173371_3276",
                    "_2022x_29f014a_1711421923720_172724_3275",
                    "98, 182, 80, 33",
                    "_17_0_1_e9b034a_1316580179343_836214_11299"
                    ),
                }
            };
            return mdOwnedViews;
        }

        public static MdOwnedViews CreateClassMdOwnedViews(string elementClass, string xmiId, string elementId, string geometry, string symbolStyleId, string text)
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
