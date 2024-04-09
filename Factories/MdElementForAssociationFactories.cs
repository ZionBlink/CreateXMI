using CreateXMI.Models.ExtensionModels;

namespace CreateXMI.Factories
{
    public class MdElementForAssociationFactories
    {

        public static MdElement CreateClassElementForAssociation(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyManagerID = propertyManagerID,
                Name = name,
                ParentPropertyManager = parentPropertyManager,
                MdElements = mdElements
            };
        }

        public static MdElement CreateClassElementForAssociationElement(string elementClass, string propertyID, string value = null)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyID = propertyID,
                Value = new Value { ValueContent = value },

            };
        }

        public static MdElement CreateClassElementForAssociationElementFontProperty(string elementClass, string propertyID, string fontName, string value = null)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyID = propertyID,
                FontName = fontName,
                Size = new Value { ValueContent = value },

            };
        }

        public static List<MdElement> CreateClassElementListForAssociation()
        {
            return new List<MdElement>
             {
                MdElementForAssociationFactories.CreateClassElementForAssociation(
                                "ExtendableManager",
                                "Association",
                                "_19_0beta_1_903028d_1491458171517_621864_119",
                                "_19_0beta_1_903028d_1491458171517_621864_119",
                                new List<MdElement>
                                {
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement(
                                        "ColorProperty",
                                    "STEREOTYPE_COLOR",
                                    "-16777216"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElementFontProperty(
                                        "FontProperty",
                                        "STEREOTYPE_FONT",
                                        "Arial",
                                        "11"
                                        ),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty","WRAP_WORDS"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_NAME", "true"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("ChoiceProperty", "DSL_STEREOTYPE_DISPLAY_MODE"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_TAGGED_VALUES", "true"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ELEMENT_PROPERTIES"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ICONS_IN_COMPARTMENTS", "true"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ELEMENT_TYPE_IN_COMPARTMENTS"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_DERIVED_SIGN"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_CONVEYED_A", "true"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_CONVEYED_B", "true"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_CONSTRAINTS", "true"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ASSOCIATION_DIRECTION_ICON"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ID_FOR_CONVEYED_ITEM", "true"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ID_OF_INFORMATION_FLOW"),
                                    MdElementForAssociationFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_NAME_OF_INFORMATION_FLOW"),


                                }
                                )
                         };
        }
    }
}
