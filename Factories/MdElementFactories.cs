using CreateXMI.Models.ExtensionModels;

namespace CreateXMI.Factories
{
    public class MdElementFactories
    {
        public static MdElement CreateDiagramFrameElement()
        {
            return new MdElement
            {
                ElementClass = "DiagramFrame",
                XmiId = "_2022x_29f014a_1711420193749_997071_3229",
                ElementID = new ElementID { IdRef = "_2022x_29f014a_1711420193669_817658_3212" },
                Geometry = "5, 5, 885, 617",
                SymbolStyleId = "_16_8beta_2104050f_1268298873363_492268_7965",
                MdOwnedViews = new MdOwnedViews()
            };
        }

        public static MdElement CreateClassElement(string elementClass, string xmiId, string idRef, string geometry, string symbolStyleId, string text = null)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                XmiId = xmiId,
                ElementID = new ElementID { IdRef = idRef },
                Geometry = geometry,
                SymbolStyleId = symbolStyleId,
                Text = text,
                MdOwnedViews = new MdOwnedViews()
            };
        }

        public static MdElement CreateClassElementForRole(string elementClass, string xmiId, string idRef, string geometry, string symbolStyleId, string roleNameId, MdOwnedViews mdOwnedViews)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                XmiId = xmiId,
                ElementID = new ElementID { IdRef = idRef },
                Geometry = geometry,
                SymbolStyleId = symbolStyleId,
                RoleNameID = new ElementID { IdRef = roleNameId },
                MdOwnedViews = mdOwnedViews
            };
        }
        // 为其他类型的mdElement添加更多的工厂方法
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

        public static MdElement CreateMdElement()
        {


            var associationElement = new MdElement
            {
                ElementClass = "Association",
                XmiId = "_2022x_29f014a_1711423265803_454423_3308",
                ElementID = new ElementID { IdRef = "_2022x_29f014a_1711423269456_677123_3309" },
                LinkFirstEndId = new ElementID { IdRef = "_2022x_29f014a_1711421319439_792255_3244" },
                LinkSecondEndId = new ElementID { IdRef = "_2022x_29f014a_1711421923724_173371_3276" },
                Geometry = "172, 110; 172, 182;",
                Compartments = new List<Compartment>
            {
                new Compartment { CompartmentId = "CONVEYED_INFORMATION_A", IsContentLocked = true },
                new Compartment { CompartmentId = "CONVEYED_INFORMATION_B", IsContentLocked = true }
            },
                NameVisible = new NameVisible { Value = true },
                MdOwnedViews = new MdOwnedViews
                {
                    MdElements = new List<MdElement>
                    {
                        MdElementFactories.CreateClassElementForRole("Role",
                                                                   "_2022x_29f014a_1711423269462_968451_3312",
                                                                   "_2022x_29f014a_1711423269457_373723_3310",
                                                                   "167, 110, 10, 10",
                                                                   "_16_8beta_2104050f_1268300673012_383197_7966",
                                                                   "_2022x_29f014a_1711423269512_434864_3318",
                                                                 MdOwnedViewsFactories.CreateClassMdOwnedViews(
                                                                     "TextBox"
                                                                 ,"_2022x_29f014a_1711423269512_434864_3318"
                                                                 ,"_2022x_29f014a_1711423269457_373723_3310"
                                                                 ,"90, 133, 79, 12"
                                                                 ,"_19_0beta_1_903028d_1491458171510_890066_8"
                                                                 ,"模块1---模----块")
                                                                   ),
                        MdElementFactories.CreateClassElement(
                             "Role"
                             ,  "_2022x_29f014a_1711423269462_23323_3315"
                             ,
                                                                   "_2022x_29f014a_1711423269457_155826_3311",
                                                                   "167, 172, 10, 10",
                                                                   "_16_8beta_2104050f_1268300673012_383197_7966"


                                                                   ),
                    }
                },
                AssociationFirstEndId = new ElementID { IdRef = "_2022x_29f014a_1711423269462_968451_3312" },
                AssociationSecondEndId = new ElementID { IdRef = "_2022x_29f014a_1711423269462_23323_3315" },
                SymbolStyleId = "_19_0beta_1_903028d_1491458171517_621864_119"
            };

            // Continue adding other MdElement instances...

            return associationElement;
        }
    }
}
