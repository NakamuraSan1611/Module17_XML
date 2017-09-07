using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Modulelem17_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "doc.xml";
            XmlDocument xdoc = new XmlDocument();
            XmlComment xcom;
            XmlDeclaration xmldecl = xdoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xdoc.AppendChild(xmldecl);

            XmlElement root = xdoc.CreateElement("Directory");
            xcom = xdoc.CreateComment("Коммент");
            root.AppendChild(xcom);
            XmlElement el1 = xdoc.CreateElement("Элемент1");
            xcom = xdoc.CreateComment("Коммент");
            el1.AppendChild(xcom);
            XmlElement el2 = xdoc.CreateElement("Элемент2");
            xcom = xdoc.CreateComment("Коммент");
            el2.AppendChild(xcom);
            XmlElement el3 = xdoc.CreateElement("Элемент3");
            xcom = xdoc.CreateComment("Коммент");
            el3.AppendChild(xcom);
            XmlElement el4 = xdoc.CreateElement("Элемент4");
            xcom = xdoc.CreateComment("Коммент");
            el4.AppendChild(xcom);

            el3.AppendChild(el4);
            el2.AppendChild(el3);
            el1.AppendChild(el2);
            root.AppendChild(el1);
            xdoc.AppendChild(root);

            XmlElement elem1 = xdoc.CreateElement("elem1");
            XmlElement elem2 = xdoc.CreateElement("elem2");
            XmlElement elem3 = xdoc.CreateElement("elem3");
            XmlElement elem4 = xdoc.CreateElement("elem4");
            XmlElement elem5 = xdoc.CreateElement("elem5");
            XmlElement elem6 = xdoc.CreateElement("elem6");
            xcom = xdoc.CreateComment("КомментЕлемент");
            elem1.AppendChild(xcom);
            xcom = xdoc.CreateComment("КомментЕлемент");
            elem2.AppendChild(xcom);
            xcom = xdoc.CreateComment("КомментЕлемент");
            elem3.AppendChild(xcom);
            xcom = xdoc.CreateComment("КомментЕлемент");
            elem4.AppendChild(xcom);
            xcom = xdoc.CreateComment("КомментЕлемент");
            elem5.AppendChild(xcom);
            xcom = xdoc.CreateComment("КомментЕлемент");
            elem6.AppendChild(xcom);

            root.AppendChild(elem1);
            root.AppendChild(elem2);
            root.AppendChild(elem3);
            root.AppendChild(elem4);
            root.AppendChild(elem5);
            root.AppendChild(elem6);

            xdoc.Save(path);
        }
    }
}
