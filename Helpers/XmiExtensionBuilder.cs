using CreateXMI.Factories;
using CreateXMI.Models;
using CreateXMI.Models.ExtensionModels;

namespace CreateXMI.Helpers
{
    public class XmiExtensionBuilder
    {

        public static XmiExtension CreateMagicDraw2022Extension()
        {
            return new XmiExtension
            {
                Extender = "MagicDraw UML 2022x",
                FilePart = new FilePart
                {
                    Name = "BINARY-4afab4af-bea9-49d8-9b77-dc04dbf4a7f8",
                    Type = "XML",
                    Header = "&lt;?xml version=&#39;1.0&#39; encoding=&#39;UTF-8&#39;?&gt;",
                    MdOwnedViews = MdElementFactories.CreateMdOwnedViews(),
                    MdElement = MdElementFactories.CreateMdElement(),
                    SymbolStyles =SymbolStylesFactories.CreateSymbolStyles(),
                }
            };
        }

        public static XmiExtension CreateMagicDraw2023Extension()
        {
            return new XmiExtension
            {
                Extender = "MagicDraw UML 2022x",
                FilePart = new FilePart
                {
                    Name = "proxy.local__PROJECT$h9b4d2b1641e6203934d95e7bde5fe08_resource_com$dnomagic$dci$dmetamodel$dproject$dsnapshot",
                    Type = "XML",
                    Header = "<?xml version=\"1.0\" encoding=\"ASCII\"?>".Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;")
                }
            };
        }
    }
}
