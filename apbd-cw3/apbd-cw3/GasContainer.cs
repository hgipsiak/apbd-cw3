namespace apbd_cw3;

public class GasContainer : Container, IHazardNotifier
{
    private double pressure;
    
    public GasContainer(double height, double outWeight, double deepness, double maxCapacity, double pressure) : 
        base(height, outWeight, deepness, maxCapacity)
    {
        this.pressure = pressure;
        this.Name = "KON-G-" + new Random().Next().ToString();
    }

    public override void Unload()
    {
        this.inWeight = 0.05 * this.inWeight;
        Console.WriteLine(this.Name + " unloaded");
    }

    public void Notify()
    {
        Console.WriteLine("WARNING: Hazardous action with container: " + this.Name);
    }
}