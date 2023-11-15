using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class FloristProduct
{
    public string name { get; set; }
    public double price { get; set; }
    public int stock { get; set; }
}

public class FloristData
{
    public List<FloristProduct> products { get; set; }
}

public class Florist
{
    public static void Main()
    {
        string json = @"{
            'products': [
                {
                    'name': 'Aloe Vera',
                    'price': 13.99,
                    'stock': 50
                },
                {
                    'name': 'Dischidia',
                    'price': 25.99,
                    'stock': 25
                },
                {
                    'name': 'Gibbaeum',
                    'price': 31.99,
                    'stock': 10
                },
                {
                    'name': 'x Graptosedum',
                    'price': 27.99,
                    'stock': 31
                },
                {
                    'name': '× Pachyveria',
                    'price': 34.99,
                    'stock': 40
                },
                {
                    'name': 'Trachyandra',
                    'price': 16.99,
                    'stock': 15
                }
            ]
        }";

        var floristData = JsonConvert.DeserializeObject<FloristData>(json);

        foreach (var product in floristData.products)
        {
            Console.WriteLine($"Product: {product.name}");
            Console.WriteLine($"Price: ${product.price}");
            Console.WriteLine($"Stock: {product.stock}\n");
        }
    }
}
