using CreateXMI.Models.ExtensionModels;

namespace CreateXMI.Factories
{
    public class MdElementForSimpleStyleFactories
    {


        public static MdElement CreateClassElementForBasicElement(string elementClass, string propertyID, string value = null)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyID = propertyID,
                Value = new Value { ValueContent = value },

            };
        }

        public static MdElement CreateClassElementForSize(string elementClass, string propertyID, string fontName, string value = null)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyID = propertyID,
                FontName = fontName,
                Size = new Value { ValueContent = value },

            };
        }
        public static MdElement CreateClassElementForIndex(string elementClass, string propertyID, string index, string value = null)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyID = propertyID,
                Index = new Value { ValueContent = value },

            };
        }

        public static List<MdElement> CreateClassElementListForSimpleStyle()
        {
            return new List<MdElement>
             {
                MdElementForSimpleStyleFactories.CreateClassElementForAssociation(
                                "ExtendableManager",
                                "Association",
                                "_19_0beta_1_903028d_1491458171517_621864_119",
                                "_19_0beta_1_903028d_1491458171517_621864_119",
                               CreateClassElementListForAssociation()
                                ),
                MdElementForSimpleStyleFactories.CreateClassElementForBlock(
                    "PropertyManagerByStereotype",
                "_11_5EAPbeta_be00301_1147424179914_458922_958",
               "Block",
               "_17_0_1_e9b034a_1316580179343_836214_11299",
               "_19_0beta_1_903028d_1491458171514_598145_73",
               CreateClassElementListForBlock()
                ),
               MdElementForSimpleStyleFactories.CreateClassElementForClass(
                   "ExtendableManager",
               "Class",
               "_19_0beta_1_903028d_1491458171514_598145_73",
               "_19_0beta_1_903028d_1491458171509_679571_3",
               CreateClassElementListForClass(),
               "SUSPEND_LABEL_AUTO_DISPLAY^SHOW_TAGGED_VALUES^LABEL_ORIENTATION"
               ),
               MdElementForSimpleStyleFactories.CreateClassElementForDiagram(
                   "ExtendableManager",
                   "Diagram",
                   "_19_0beta_1_903028d_1491458171517_36964_121",
                   "_19_0beta_1_903028d_1491458171509_49302_1",
                   CreateClassElementListForDiagram(),
                   "USE_FILL_COLOR^FILL_COLOR"
                   ),
                MdElementForSimpleStyleFactories.CreateClassElementForPaths("ExtendableManager",
                "Paths",
                "_19_0beta_1_903028d_1491458171509_301592_2",
                "_19_0beta_1_903028d_1491458171509_49302_1",
                CreateClassElementListForPaths()
                ),
                MdElementForSimpleStyleFactories.CreateClassElementForRole(
                    "ExtendableManager",
                    "Role",
                    "_19_0beta_1_903028d_1491458171510_495256_18",
                    "_19_0beta_1_903028d_1491458171509_679571_3",
                    CreateClassElementListForRole(),
                    "SHOW_HEADER_IN_BOLD^USE_FILL_COLOR^AUTOSIZE^PEN_COLOR^FILL_COLOR^QNAME_DISPLAY_MODE^USE_FIXED_CONNECTION_POINTS"

                    ),
               MdElementForSimpleStyleFactories.CreateClassElementForShapes("ExtendableManager",
                "Shapes",
                "_19_0beta_1_903028d_1491458171509_679571_3",
                "_19_0beta_1_903028d_1491458171509_49302_1",
                CreateClassElementListForShapes()),
               MdElementForSimpleStyleFactories.CreateClassElementForSymbol("ExtendableManager",
                "Symbol",
                "_19_0beta_1_903028d_1491458171509_49302_1",
                CreateClassElementListForSymbol()),
                MdElementForSimpleStyleFactories.CreateClassElementForSysMLBlockDefinitionDiagram(
                    "PropertyManagerByDiagram",
                "SysML Block Definition Diagram",
                "_16_8beta_2104050f_1268298873363_492268_7965","_19_0beta_1_903028d_1491458171517_36964_121",
                CreateClassElementListForSysMLBlockDefinitionDiagram1()),
                MdElementForSimpleStyleFactories.CreateClassElementForSysMLBlockDefinitionDiagram(
                    "PropertyManagerByDiagram",
                "SysML Block Definition Diagram",
                "_16_8beta_2104050f_1268300673012_383197_7966","_19_0beta_1_903028d_1491458171510_495256_18",
                CreateClassElementListForSysMLBlockDefinitionDiagram2()),
                 MdElementForSimpleStyleFactories.CreateClassElementForTextBox("ExtendableManager",
                "TextBox",
                "_19_0beta_1_903028d_1491458171510_890066_8",
                "_19_0beta_1_903028d_1491458171509_679571_3",
                CreateClassElementListForTextBox(),
                "SHOW_CONSTRAINTS^TAGGED_VALUE_HORIZONTAL_POSITION^CONSTRAINT_TEXT_MODE^STEREOTYPE_FONT^SUSPEND_LABEL_AUTO_DISPLAY^STEREOTYPE_COLOR^STEREOTYPES_DISPLAY_MODE^SHOW_DERIVED_SIGN^LABEL_ORIENTATION^SHOW_ICONS_IN_COMPARTMENTS^SHOW_HEADER_IN_BOLD^PEN_COLOR^SHOW_TAGGED_VALUES^SHOW_ELEMENT_TYPE_IN_COMPARTMENTS^DSL_STEREOTYPE_DISPLAY_MODE^SHOW_ELEMENT_PROPERTIES^QNAME_DISPLAY_MODE"
                ),
                         };
        }
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

        public static List<MdElement> CreateClassElementListForAssociation()
        {
            return new List<MdElement>
            {    MdElementForSimpleStyleFactories.CreateClassElementForBasicElement(
                                        "ColorProperty",
                                    "STEREOTYPE_COLOR",
                                    "-16777216"),
                MdElementForSimpleStyleFactories.CreateClassElementForSize(
                                        "FontProperty",
                                        "STEREOTYPE_FONT",
                                        "Arial",
                                        "11"
                                        ),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty","WRAP_WORDS"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_NAME", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "DSL_STEREOTYPE_DISPLAY_MODE"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_TAGGED_VALUES", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ELEMENT_PROPERTIES"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ICONS_IN_COMPARTMENTS", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ELEMENT_TYPE_IN_COMPARTMENTS"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DERIVED_SIGN"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONVEYED_A", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONVEYED_B", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONSTRAINTS", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ASSOCIATION_DIRECTION_ICON"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ID_FOR_CONVEYED_ITEM", "true"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ID_OF_INFORMATION_FLOW"),
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_NAME_OF_INFORMATION_FLOW"),
            };
        }

        public static MdElement CreateClassElementForBlock(string elementClass, string stereotype, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                Stereotype = stereotype,
                PropertyManagerID = propertyManagerID,
                Name = name,
                ParentPropertyManager = parentPropertyManager,
                MdElements = mdElements
            };
        }

        public static List<MdElement> CreateClassElementListForBlock()
        {
            return new List<MdElement>
    {
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "FILL_COLOR", "-2241122"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONSTRAINTS"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_CLASS_ATTRIBUTES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "SHOW_ASSOCIATION_ENDS_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_VISIBILITY"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_CLASS_OPERATIONS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_VISIBILITY"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_STEREOTYPE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_PROPERTIES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_TAGGED_VALUES"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "TAGGED_VALUES_DISPLAY_MODE", "2"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_STEREOTYPE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_PROPERTIES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_TAGGED_VALUES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_STEREOTYPES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_PROPERTIES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_TAGGED_VALUES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SORT_SYSML_STYLE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_CONSTRAINTS_COMPARTMENT"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_PARTS_COMPARTMENT"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_PROPERTIES_COMPARTMENT"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_REFERENCES_COMPARTMENT"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_VALUES_COMPARTMENT"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_FLOWPROPERTIES_COMPARTMENT"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_FULLPORTS_COMPARTMENT", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_PROXYPORTS_COMPARTMENT", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_FEATUREDIRECTION", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "FULL_PORTS_COMPARTMENT_NAME_PROPERTY_ID", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DIRECTION_FOR_PROXY_PORT_COMPARTMENT", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_FLOW_PROPERTY_UNIT", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SYSML_CALLOUT_STYLE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SYSML_ELEMENT_TYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_UNITS_ON_VALUE_PROPERTY"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "ALLOCATION_COMPARTMENT_NAMING", "true"),
    };


        }

        public static MdElement CreateClassElementForClass(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements, string hiddenProperties)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyManagerID = propertyManagerID,
                Name = name,
                ParentPropertyManager = parentPropertyManager,
                MdElements = mdElements,
                HiddenProperties = new Value { ValueContent = hiddenProperties }
            };
        }
        public static List<MdElement> CreateClassElementListForClass()
        {
            return new List<MdElement>
            {
              MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "FILL_COLOR", "-13159"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "PEN_COLOR", "-6719140"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE", "3"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SHOW_MEMBERS_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_INHERITED"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_CLASS_ATTRIBUTES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "ATTRIBUTE_COLOR", "-14155776"),
        MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "ATTRIBUTE_FONT", "Arial", "11"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_MORE_SIGN_FOR_ATTRIBUTES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SORT_CLASS_ATTRIBUTES_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "SHOW_ASSOCIATION_ENDS_MODE", "2"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_VISIBILITY", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_INHERITED_SIGN", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_COMPARTMENT_NAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_TYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_STEREOTYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_PROPERTIES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_TAGGED_VALUES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ATTRIBUTES_CONSTRAINTS"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "ATTRIBUTES_CONSTRAINT_TEXT_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_INIT_VALUE", "true"),
         MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_CLASS_OPERATIONS"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_COMPARTMENT_NAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "OPERATION_COLOR", "-16777176"),
        MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "OPERATION_FONT", "Arial", "11"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_SIGNATURE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_MORE_SIGN_FOR_OPERATIONS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SORT_CLASS_OPERATIONS_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_VISIBILITY", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_INHERITED_SIGN", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_STEREOTYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_PROPERTIES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_TAGGED_VALUES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_CONSTRAINTS"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "OPERATIONS_CONSTRAINT_TEXT_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_FULL_TYPE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_ADVANCED_COLORING", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_OPERATIONS_PARAMETERS_DIRECTION_KIND"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "TAGGED_VALUES_DISPLAY_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_TAGGED_VALUES_STEREOTYPES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_QUALIFIED_NAME_IN_TAGGED_VALUES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "MEMBERS_WORD_WRAP"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_CLASS_PORTS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_COMPARTMENT_NAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "PORTS_COLOR", "-14155776"),
        MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "PORTS_FONT", "Arial", "11"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_MORE_SIGN_FOR_PORTS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SORT_CLASS_PORT_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "SHOW_ASSOCIATION_ENDS_PORTS_MODE", "2"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_VISIBILITY"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_INHERITED_SIGN", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_TYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_STEREOTYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_PROPERTIES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_TAGGED_VALUES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PORTS_CONSTRAINTS"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "PORTS_CONSTRAINTS_TEXT_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_INIT_PORTS_VALUE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_BEHAVIORS", "true"),
       // 继续添加到CreateClassElementListForClass方法中
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "BEHAVIORS_COLOR", "-14155776"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_BEHAVIORS_INHERITED_SIGN", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_MORE_SIGN_FOR_BEHAVIORS", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_BEHAVIORS_PROPERTIES"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_BEHAVIORS_TAGGED_VALUES"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_BEHAVIORS_CONSTRAINTS"),
MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "BEHAVIORS_CONSTRAINT_TEXT_MODE", "1"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_BEHAVIORS_SIGNATURE", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_BEHAVIORS_PARAMETERS_DIRECTION_KIND"),
MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "BEHAVIORS_FONT", "Arial", "11"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_BEHAVIORS_STEREOTYPE", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_SIGNAL_RECEPTIONS", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "RECEPTION_COLOR", "-16777176"),
MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "RECEPTION_FONT", "Arial", "11"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_SIGNAL_RECEPTIONS_SIGNATURE", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_MORE_SIGN_FOR_RECEPTIONS", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SORT_CLASS_RECEPTIONS_MODE"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_SIGNAL_RECEPTIONS_VISIBILITY"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_INHERITED_SIGN", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_STEREOTYPES", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_PROPERTIES", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_TAGGED_VALUES", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_CONSTRAINTS"),
MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "RECEPTIONS_CONSTRAINTS_TEXT_MODE", "1"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_PARAMETERS_DIRECTION_KIND"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUPPRESS_STRUCTURE", "true"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "BORDER_ELEMENT_MARGIN"),
MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_RECEPTIONS_COMPARTMENT_NAME", "true"),

            };
        }

        public static MdElement CreateClassElementForDiagram(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements, string hiddenProperties)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyManagerID = propertyManagerID,
                Name = name,
                ParentPropertyManager = parentPropertyManager,
                MdElements = mdElements,
                HiddenProperties = new Value { ValueContent = hiddenProperties }
            };
        }
        public static List<MdElement> CreateClassElementListForDiagram()
        {
            return new List<MdElement>
    {
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "DIAGRAM_BACKGROUND_COLOR", "-1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_GRADIENT_FOR_FILL", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_SHADOW_FOR_SHAPES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_GRID"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("NumberProperty", "GRID_SIZE", "7.0"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_GRID_FOR_PATHS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_GRID_FOR_SHAPES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_MESSAGE_NUMBERS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_ADVANCED_NUMBERING", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ACTIVATIONS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DIAGRAM_INFO"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DIAGRAM_OWNER"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DIAGRAM_FRAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ABBREVIATED_DIAGRAM_TYPE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DIAGRAM_NAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DIAGRAM_TYPE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PARAMETERS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONTEXT_NAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONTEXT_TYPE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_FRAME_OWNER", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "AUTOSIZE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "ASPECT_RATIO"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_ROUNDED_CORNERS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "DSL_STEREOTYPE_DISPLAY_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "USE_STEREOTYPE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "STEREOTYPE_COLOR", "-16777216"),
        MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "STEREOTYPE_FONT", "Arial", "11"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "DIAGRAM_ORIENTATION"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "LINE_JUMP_PLACE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUSPEND_SHAPES_AUTO_RESIZE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SUSPEND_LABELS_AUTO_DISPLAY"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SUSPEND_SHAPE_AUTO_RESIZE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_SYSML_INTERNAL_PROPERTIES_COMPARTMENTS", "true"),

    };
        }

        public static MdElement CreateClassElementForPaths(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements)
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

        public static List<MdElement> CreateClassElementListForPaths()
        {

            return new List<MdElement> {
            MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_FILL_COLOR"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "LINK_LINE_STYLE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "IS_ROUNDED"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "CONSTRAINT_TEXT_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SUSPEND_SHAPE_AUTO_RESIZE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SUSPEND_LABEL_AUTO_DISPLAY"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "LABEL_ORIENTATION"),

            };
        }

        public static MdElement CreateClassElementForRole(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements, string hiddenProperties)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyManagerID = propertyManagerID,
                Name = name,
                ParentPropertyManager = parentPropertyManager,
                MdElements = mdElements,
                HiddenProperties = new Value { ValueContent = hiddenProperties }
            };
        }
        public static List<MdElement> CreateClassElementListForRole()
        {
            return new List<MdElement>
            {
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ROLE_NAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ROLE_NAVIGABILITY", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ROLE_VISIBILITY", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ROLE_MULTIPLICITY", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ROLE_PROPERTY_STRING", "true"),

            };
        }

        public static MdElement CreateClassElementForShapes(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements)
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
        public static List<MdElement> CreateClassElementListForShapes()
        {
            return new List<MdElement>
            {
                   MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "AUTOSIZE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_FIXED_CONNECTION_POINTS"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SUSPEND_SHAPE_AUTO_RESIZE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "SUSPEND_LABEL_AUTO_DISPLAY"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "LABEL_ORIENTATION"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_HEADER_IN_BOLD", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "TEXT_VERTICAL_POSITION"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "STEREOTYPE_COLOR", "-16777216"),
        MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "STEREOTYPE_FONT", "Arial", "11"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "DSL_STEREOTYPE_DISPLAY_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONSTRAINTS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ChoiceProperty", "QNAME_DISPLAY_MODE"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "WRAP_WORDS"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_TAGGED_VALUES", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "TAGGED_VALUE_HORIZONTAL_POSITION", "2"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "CONSTRAINT_TEXT_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ELEMENT_PROPERTIES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ICONS_IN_COMPARTMENTS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ELEMENT_TYPE_IN_COMPARTMENTS"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DERIVED_SIGN"),
            };
        }

        public static MdElement CreateClassElementForSymbol(string elementClass, string name, string propertyManagerID, List<MdElement> mdElements)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyManagerID = propertyManagerID,
                Name = name,
                MdElements = mdElements
            };
        }
        public static List<MdElement> CreateClassElementListForSymbol()
        {
            return new List<MdElement>
            {
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "FILL_COLOR", "-52"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_FILL_COLOR", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "PEN_COLOR", "-12434878"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("ColorProperty", "TEXT_COLOR", "-16777216"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("NumberProperty", "LINE_WIDTH", "1.0"),
        MdElementForSimpleStyleFactories.CreateClassElementForSize("FontProperty", "FONT", "Arial", "11"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_NUMBER_TAG_NAME", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "ELEMENT_NUMBER_DISPLAY_MODE", "1"),

            };
        }
        public static MdElement CreateClassElementForSysMLBlockDefinitionDiagram(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements)
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
        public static List<MdElement> CreateClassElementListForSysMLBlockDefinitionDiagram1()
        {
            return new List<MdElement>
            {
                MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ABBREVIATED_DIAGRAM_TYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_DIAGRAM_TYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_PARAMETERS"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_CONTEXT_TYPE", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_FRAME_OWNER"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_ROUNDED_CORNERS"),
        MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE", "1"),

            };
        }

        public static List<MdElement> CreateClassElementListForSysMLBlockDefinitionDiagram2()
        {
            return new List<MdElement>
            {
                 MdElementForSimpleStyleFactories.CreateClassElementForIndex("ChoiceProperty", "STEREOTYPES_DISPLAY_MODE", "1"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_TAGGED_VALUES"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "SHOW_ROLE_VISIBILITY"),

            };
        }

        public static MdElement CreateClassElementForTextBox(string elementClass, string name, string propertyManagerID, string parentPropertyManager, List<MdElement> mdElements, string hiddenProperties)
        {
            return new MdElement
            {
                ElementClass = elementClass,
                PropertyManagerID = propertyManagerID,
                Name = name,
                ParentPropertyManager = parentPropertyManager,
                MdElements = mdElements,
                HiddenProperties = new Value { ValueContent = hiddenProperties }

            };
        }

        public static List<MdElement> CreateClassElementListForTextBox()
        {
            return new List<MdElement>
            {
                 MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "USE_FILL_COLOR"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "WRAP_WORDS", "true"),
        MdElementForSimpleStyleFactories.CreateClassElementForBasicElement("BooleanProperty", "HTML_TEXT"),

            };
        }
    }
}
