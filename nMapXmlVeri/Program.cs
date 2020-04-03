using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nMapXmlVeri
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmldoc = XDocument.Load("out.xml");
            XName FileStream = XName.Get("host", xmldoc.Root.Name.NamespaceName);
            foreach (XElement file in xmldoc.Descendants(FileStream))
            {
                Console.WriteLine(file.ToString());

                file.Save("outt.xml");
            }
            Console.ReadKey();

        }
    }
}
