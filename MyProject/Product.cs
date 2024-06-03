public class Product {
    private int ProductID { get; set; }

    private string ProductName { get; set; }

    private int Price { get; set; }

    private int Stock { get; set; }

    public Product(int productID, string productName, int price, int stock){
        ProductID = productID;
        ProductName = productName;
        Price = price;
        Stock = stock;
    }

    public void IncreaseStock(int quantity)
    {
            Stock += quantity;
    }

    public void DecreaseStock(int quantity)
    {
        Stock -= quantity;
    }
}