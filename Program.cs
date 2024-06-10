using AMST4_ClassObject.Models;


Category category = new Category("Meias");
Console.WriteLine($"Id: {category.Id}");
Console.WriteLine($"Descrição: {category.CategoryDescription}");
Console.WriteLine($"Está Ativo: {category.IsActive}");

Console.WriteLine("---------------------------------------------------------------");

Product product = new Product("Tenis Nike",Convert.ToDouble("129,90"));
Console.WriteLine($"Id: {product.Id}");
Console.WriteLine($"Descrição: {product.Description}");
Console.WriteLine($"Preço: {product.Price}");
Console.WriteLine($"Está Ativo: {product.IsActive}");