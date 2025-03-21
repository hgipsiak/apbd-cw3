namespace apbd_cw3;

public class CoolingContainer : Container
{
    private double temperature {get; set;}
    private Product heldProduct {get; set;}
    
    public CoolingContainer(double height, double outWeight, double deepness, double maxCapacity, double temperature, Product heldProduct) : 
        base(height, outWeight, deepness, maxCapacity)
    {
        this.Name = "KON-C-" + new Random().Next().ToString();
        this.temperature = temperature;
        this.heldProduct = heldProduct;
        if (this.heldProduct.Temperature > this.temperature)
        {
            Console.WriteLine("Container temperature lower than temperature of the held product. Setting a proper temperature");
            this.temperature = this.heldProduct.Temperature;
        }
    }

    public void loadUp(double amount, Product product)
    {
        if (product.Name.Equals(this.heldProduct.Name))
        {
            this.inWeight += amount;
        }
        Console.WriteLine("Container can only hold this product: " + this.heldProduct.Name);
    }
}