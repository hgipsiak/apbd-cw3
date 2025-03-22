namespace apbd_cw3;

public class Container
{
    protected double inWeight { get; set; }
    private double height { get; set; }
    private double outWeight { get; set; }
    private double deepness { get; set; }
    private string name { get; set; }
    private double maxCapacity { get; set; }
    public string Name { get => name; set => name = value; }
    public double MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
    public double InWeight { get => inWeight; set => inWeight = value; }

    public Container(double height, double outWeight, double deepness, double maxCapacity)
    {
        this.inWeight = 0;
        this.height = height;
        this.outWeight = outWeight;
        this.deepness = deepness;
        this.maxCapacity = maxCapacity;
        this.name = "KON-" + 0 + "-" + new Random().Next().ToString();
    }

    public virtual void unload()
    {
        this.inWeight = 0;
        Console.WriteLine(this.Name + " unloaded");
    }

    public virtual void loadUp(double amount)
    {
        if (amount > this.maxCapacity)
        {
            throw new OverflowException();
        }
        this.inWeight = amount;
    }

    public void showInfo()
    {
        Console.WriteLine("Name: " + this.Name + "\n inWeight: " 
                          + this.inWeight + "\n outWeight: " +
                          this.outWeight + "\n deepness: " +
                          this.deepness + "\n maxCapacity: " +
                          this.maxCapacity + "\n height: " +
                          this.height);
    }
}