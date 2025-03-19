namespace apbd_cw3;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double inWeight, double height, double outWeight, double deepness, string name, double maxCapacity, ContainerType containerType) : 
        base(inWeight, height, outWeight, deepness, name, maxCapacity, containerType)
    {
        this.name = "KON-" + ContainerType.G.ToString() + new Random().Next().ToString();
    }

    public override void clear()
    {
        this.inWeight = 0.05 * this.inWeight;
    }

    public void Notify()
    {
        Console.WriteLine("WARNING: Hazardous action with container: " + this.name);
    }
}