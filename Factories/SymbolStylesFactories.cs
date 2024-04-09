using CreateXMI.Models.ExtensionModels;

namespace CreateXMI.Factories
{
    public class SymbolStylesFactories
    {
        public static SymbolStyles CreateSymbolStyles()
        {
            var symbolStyles = new SymbolStyles()
            {
                MdElements = new List<MdElement> {
                    new MdElement 
                    {
                        ElementClass="SimpleStyle",
                         MdElements = new List<MdElement> {
                         
                         }

                    },
                    

                }
            };

            return symbolStyles;
        }

    }
}
