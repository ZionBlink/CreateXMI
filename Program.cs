using CreateXMI.Factories;
using CreateXMI.Helper;
using CreateXMI.Models;
using System.Xml.Serialization;

namespace CreateXMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelExtension modelExtension = new ModelExtension
            {
                OwnedDiagram = new OwnedDiagram
                {
                    XmiType = "uml:Diagram",
                    XmiId = "_2022x_29f014a_1711420193669_817658_3212",
                    Name = "Model",
                    Visibility = "public",
                    OwnerOfDiagram = "eee_1045467100313_135436_1",
                    XmiExtension = new XmiExtension
                    {
                        Extender = "MagicDraw UML 2022x",
                        DiagramRepresentation = new DiagramRepresentation
                        {
                            DiagramRepresentationObject = new DiagramRepresentationObject
                            {
                                xmlns = new XmlSerializerNamespaces(),
                                ID = "_2022x_29f014a_1711420193748_519465_3228",
                                InitialFrameSizeSet = "true",
                                RequiredFeature = "com.nomagic.magicdraw.plugins.impl.sysml#SysML;UML_Standard_Profile.mdzip;MD_customization_for_SysML.mdzip",
                                Type = "SysML Block Definition Diagram",
                                UmlType = "Class Diagram",
                                Id = "_uppwUOsYEe6Nh4Rdl8QQug",
                                XmiVersion = "2.0",
                                DiagramContents = new DiagramContents
                                {
                                    ContentHash = "197ce51a8a4544f57cf724c09fa87698fa53c6b3",
                                    ExporterName = "MagicDraw UML",
                                    ExporterVersion = "2022x v7",
                                    Id = "_uppwUesYEe6Nh4Rdl8QQug",
                                    BinaryObject = new BinaryObject
                                    {
                                        StreamContentId = "BINARY-4afab4af-bea9-49d8-9b77-dc04dbf4a7f8",
                                        Id = "_uppwUusYEe6Nh4Rdl8QQug",
                                        XsiType = "binary:StreamIdentityBinaryObject"
                                    },
                                    UsedObjects = new UsedObjects[]
                                   {
                                        new UsedObjects { Href = "#_2022x_29f014a_1711421319433_506189_3243" },
                                        new UsedObjects { Href = "#_2022x_29f014a_1711421923720_172724_3275" },
                                        new UsedObjects { Href = "#_2022x_29f014a_1711423269456_677123_3309" },
                                        new UsedObjects { Href = "#_2022x_29f014a_1711423269457_373723_3310" },
                                        new UsedObjects { Href = "#_2022x_29f014a_1711423269457_155826_3311" }
                                   },
                                    UsedElements = new UsedElements[]
                                   {
                                        new UsedElements { Value = "_2022x_29f014a_1711423269456_677123_3309" },
                                        new UsedElements { Value = "_2022x_29f014a_1711421319433_506189_3243" },
                                        new UsedElements { Value = "_2022x_29f014a_1711423269457_155826_3311" },
                                        new UsedElements { Value = "_2022x_29f014a_1711421923720_172724_3275" },
                                        new UsedElements { Value = "_2022x_29f014a_1711423269457_373723_3310" }
                                   }
                                }
                            }
                        }
                    }
                }
            };

            XmiExtension XmiExtension = new XmiExtension
            {
                Extender = "MagicDraw UML 2022x",
                ModelExtension = modelExtension,
            };

            var ownedComment = new OwnedComment
            {
                Type = "umlComment",
                Id = "_2022x_29f014a_1711420009373_337557_3087",
                Body = "Author:yao",
                AnnotatedElement = new AnnotatedElement
                {
                    IdRef = "eee_1045467100313_135436_1"
                }
            };

            var packagedElements = new PackagedElement[]
            {
                 new PackagedElement
                {
                    Type = "uml:Class",
                    Id = "_2022x_29f014a_1711421319433_506189_3243",
                    Name = "模块test1111",
                },
                new PackagedElement
                {
                    Type = "uml:Class",
                    Id = "_2020x_29f014a_1711421923720_172724_3275",
                    Name = "模块2",
                    OwnedAttributes = new OwnedAttribute
                    {

                            XmiType = "uml:Property",
                            XmiId = "_2020x_29f014a_1711423269457_373723_3310",
                            Name = "模块1---模块----",
                            Visibility = "public",
                            Type = "_2020x_29f014a_1711421319433_506189_3243",
                            Association = "_2020x_29f014a_1711423269456_677123_3309"

                    }
                },
                 new PackagedElement
                {
                    Type = "uml:Association",
                    Id = "_2022x_29f014a_1711423269456_677123_3309",
                    MemberEnds = new MemberEnd[]
                    {
                        new MemberEnd { IdRef = "_2022x_29f014a_1711423269457_373723_3310" },
                        new MemberEnd { IdRef = "_2022x_29f014a_1711423269457_155826_3311" }
                    },
                    OwnedEnd = new OwnedEnd
                    {
                        Type = "uml:Property",
                        Id = "_2022x_29f014a_1711423269457_155826_3311",
                        Visibility = "public",
                        TypeId = "_2022x_29f014a_1711421923720_172724_3275",
                        AssociationId = "_2022x_29f014a_1711423269456_677123_3309"
                    }
                }
            };

            ProfileApplication profileApplication = new ProfileApplication
            {
                XmiType = "uml:ProfileApplication",
                XmiId = "_2022x_29f014a_1711420009371_859607_3046",
                AppliedProfile = new AppliedProfile
                {
                    Href = "http://www.omg.org/spec/SysML/20181001/SysML.xmi#SysML",
                    XmiExtension = new XmiExtension
                    {
                        Extender = "MagicDraw UML 2022x",
                        ReferenceExtension = new ReferenceExtension
                        {
                            ReferentPath = "SysML",
                            ReferentType = "Profile",
                            OriginalId = "_11_5EAPbeta_be00301_1147434586638_637562_1900"
                        }
                    }
                }
            };

            var model = new Model
            {
                Type = "uml:Model",
                Id = "eee_1045467100313_135436_1",
                Name = "Model",
                ownedComment = ownedComment,
                packagedElements = packagedElements,
                profileApplication = profileApplication,
                xmiExtension = XmiExtension,
            };

            XMI xmi = new XMI
            {
                Documentation = new Documentation
                {
                    Exporter = "MagicDraw UML",
                    ExporterVersion = "2022x v7"
                },
                model = model,
                Extensions = new List<XmiExtension>
                {
                    XmiExtensionBuilder.CreateMagicDraw2022Extension(),
                    XmiExtensionBuilder.CreateMagicDraw2023Extension(),
                },
            };



            xmi.model.xmiExtension.ModelExtension.OwnedDiagram.XmiExtension.DiagramRepresentation.DiagramRepresentationObject.xmlns.Add("binary", "http://www.nomagic.com/ns/cameo/client/binary/1.0");
            xmi.model.xmiExtension.ModelExtension.OwnedDiagram.XmiExtension.DiagramRepresentation.DiagramRepresentationObject.xmlns.Add("diagram", "http://www.nomagic.com/ns/magicdraw/core/diagram/1.0");
            xmi.model.xmiExtension.ModelExtension.OwnedDiagram.XmiExtension.DiagramRepresentation.DiagramRepresentationObject.xmlns.Add("xmi", "http://www.omg.org/XMI");
            xmi.model.xmiExtension.ModelExtension.OwnedDiagram.XmiExtension.DiagramRepresentation.DiagramRepresentationObject.xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            // Use SerializationHelper to serialize the model to XML
            string xmlContent = SerializationHelper.SerializeObjectToXml(xmi);
            Console.WriteLine(xmlContent);

            File.WriteAllText("your_model.xml", xmlContent);
        }
    }
}
