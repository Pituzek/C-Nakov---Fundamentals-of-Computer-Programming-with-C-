using System;
using System.Linq;
using System.Xml;
using System.IO;
using System.Net;


namespace Rozdzial15_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10. Write a program that extracts from an XML file the text only (without the tags).Sample input file:");
            /*
             * 
             <?xml version="1.0"?>
             <student>
	             <name>Peter</name>
	             <age>21</age>
	                 <interests count="3">
		                 <interest>Games</interest>
		                 <interest>C#</interest>
		                 <interest>Java</interest>
	                 </interests>
             </student>
             * 
             * 
             */

            try
            {

                string filePath = "../../File1.in.txt";

                XmlTextReader xmlReader = new XmlTextReader(filePath);

                while (xmlReader.Read())
                {
                    switch(xmlReader.NodeType)
                    {
                        case XmlNodeType.Text:
                            Console.WriteLine("{0}", xmlReader.Value);
                            break;
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(UriFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(XmlException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}
