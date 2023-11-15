using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Creating XML document representing florist products
        XElement florist = new XElement("Florist",
            new XElement("Product",
                new XAttribute("ID", "1"),
                new XElement("Name", "Aloe Vera"),
                new XElement("Price", "13.99")
            ),
            new XElement("Product",
                new XAttribute("ID", "2"),
                new XElement("Name", "Dischidia"),
                new XElement("Price", "25.99")
            ),
            new XElement("Product",
                new XAttribute("ID", "3"),
                new XElement("Name", "Gibbaeum"),
                new XElement("Price", "31.99")
            ),
            new XElement("Product",
                new XAttribute("ID", "4"),
                new XElement("Name", "x Graptosedum"),
                new XElement("Price", "27.99")
            ),
            new XElement("Product",
                new XAttribute("ID", "5"),
                new XElement("Name", "× Pachyveria"),
                new XElement("Price", "34.99")
            ),
            new XElement("Product",
                new XAttribute("ID", "6"),
                new XElement("Name", "Trachyandra"),
                new XElement("Price", "16.99")
            )
        );

        // Save XML document to a file
        XDocument doc = new XDocument(florist);
        doc.Save("florist.xml");


        // Querying and displaying florist products
        var products = florist.XPathSelectElements("//Product");
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Attribute("ID").Value}");
            Console.WriteLine($"Name: {product.Element("Name").Value}");
            Console.WriteLine($"Price: {product.Element("Price").Value}\n");
        }
    }
}
