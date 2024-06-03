public class Product {
    public int ProductID { get; set; }

    public string ProductName { get; set; }

    public int Price { get; set; }

    public int Stock { get; set; }

    public Product(int productID, string productName, int price, int stock){
        ProductID = productID;
        ProductName = productName;
        Price = price;
        Stock = stock;
    }

    public void IncreaseStock(int quantity)
    {
        if(quantity<0){
            return;
        }
        if(Stock+quantity>600000){
                Stock = 600000;
        } else {
                Stock += quantity;

        }
        
            
    }

    public void DecreaseStock(int quantity)
    {
        if(quantity<0){
            return;
        }
        if(Stock-quantity<6){
                Stock = 6;
            } else{
                Stock -= quantity;
            }
        
    }
}