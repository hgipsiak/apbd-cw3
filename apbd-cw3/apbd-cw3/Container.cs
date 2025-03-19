namespace apbd_cw3;

public class Container
{
    protected double inWeight { get; set; }
    private double height { get; set; }
    private double outWeight { get; set; }
    private double deepness { get; set; }
    protected string name { get; set; }
    protected double maxCapacity { get; set; }

    public Container(double inWeight, double height, double outWeight, double deepness, string name, double maxCapacity, ContainerType containerType)
    {
        this.inWeight = inWeight;
        this.height = height;
        this.outWeight = outWeight;
        this.deepness = deepness;
        this.maxCapacity = maxCapacity;
        this.name = "KON-" + containerType.ToString() + "-" + new Random().Next().ToString();
    }

    public virtual void clear()
    {
        this.inWeight = 0;
    }

    public virtual void loadUp(double amount)
    {
        if (amount > this.maxCapacity)
        {
            throw new OverflowException();
        }
        this.inWeight = amount;
    }
}