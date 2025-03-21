namespace apbd_cw3;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double height, double outWeight, double deepness, double maxCapacity) : 
        base(height, outWeight, deepness, maxCapacity)
    {
        this.Name = "KON-G-" + new Random().Next().ToString();
    }

    public override void clear()
    {
        this.inWeight = 0.05 * this.inWeight;
    }

    public void Notify()
    {
        Console.WriteLine("WARNING: Hazardous action with container: " + this.Name);
    }
}