namespace apbd_cw3;

public class Product
{
    private string name;
    public string Name {get; set; }
    private double temperature;
    public double Temperature {get => temperature; set => temperature = value; }

    public Product(string name, double temperature)
    {
        this.Name = name;
        this.Temperature = temperature;
    }
    
}