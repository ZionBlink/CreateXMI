using CreateXMI.Models.ExtensionModels;

namespace CreateXMI.Factories
{
    public class MdElementForSimpleStyleFactories
    {

        public static MdElement CreateClassElementForSimpleStyle(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements)
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

        public static List<MdElement> CreateClassElementListForSimpleStyle()
        {
            return new List<MdElement>
             {
                MdElementForSimpleStyleFactories.CreateClassElementForSimpleStyle(
                                "ExtendableManager",
                                "Association",
                                "_19_0beta_1_903028d_1491458171517_621864_119",
                                "_19_0beta_1_903028d_1491458171517_621864_119",
                               CreateClassElementListForAssociation()
                                ),

                         };
        }

        public static List<MdElement> CreateClassElementListForAssociation()
        {
            return new List<MdElement>
            {    MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement(
                                        "ColorProperty",
                                    "STEREOTYPE_COLOR",
                                    "-16777216"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElementFontProperty(
                                        "FontProperty",
                                        "STEREOTYPE_FONT",
                                        "Arial",
                                        "11"
                                        ),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty","WRAP_WORDS"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_NAME", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("ChoiceProperty", "DSL_STEREOTYPE_DISPLAY_MODE"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_TAGGED_VALUES", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ELEMENT_PROPERTIES"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ICONS_IN_COMPARTMENTS", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ELEMENT_TYPE_IN_COMPARTMENTS"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_DERIVED_SIGN"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_CONVEYED_A", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_CONVEYED_B", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_CONSTRAINTS", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ASSOCIATION_DIRECTION_ICON"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ID_FOR_CONVEYED_ITEM", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_ID_OF_INFORMATION_FLOW"),
                MdElementForSimpleStyleFactories.CreateClassElementForAssociationElement("BooleanProperty", "SHOW_NAME_OF_INFORMATION_FLOW"),
            };
        }
    }
}
