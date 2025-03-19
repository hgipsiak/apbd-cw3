using System.ComponentModel;

namespace apbd_cw3;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isHazardous;
    
    public LiquidContainer(double inWeight, double height, double outWeight, double deepness, string name, double maxCapacity, ContainerType containerType, bool isHazardous) : 
        base(inWeight, height, outWeight, deepness, name, maxCapacity, containerType)
    {
        this.name =  "KON-" + ContainerType.L.ToString() + "-" + new Random().Next().ToString();
        this.isHazardous = isHazardous;
        
    }

    public void Notify()
    {
        Console.WriteLine("WARNING: Hazardous action with container: " + this.name);
    }

    public override void loadUp(double amount)
    {
        if (this.isHazardous)
        {
            Console.WriteLine("This container can be loaded up only to 50% of its capacity");
        }
        Console.WriteLine("This container can be loaded up only to 90% of its capacity");

        if (this.isHazardous && amount > 0.9 * this.maxCapacity)
        {
            Notify();
        }

        this.inWeight = amount;
    }
    
    
    
}