using System.ComponentModel;

namespace apbd_cw3;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isHazardous;
    
    public LiquidContainer(double height, double outWeight, double deepness, double maxCapacity, bool isHazardous) : 
        base(height, outWeight, deepness, maxCapacity)
    {
        this.Name =  "KON-L-" + new Random().Next().ToString();
        this.isHazardous = isHazardous;
        
    }

    public void Notify()
    {
        Console.WriteLine("WARNING: Hazardous action with container: " + this.Name);
    }

    public override void loadUp(double amount)
    {
        if (this.isHazardous)
        {
            Console.WriteLine("This container can be loaded up only to 50% of its capacity");
        }
        Console.WriteLine("This container can be loaded up only to 90% of its capacity");

        if (this.isHazardous && amount > 0.9 * this.MaxCapacity)
        {
            Notify();
        }

        this.inWeight = amount;
    }
    
    
    
}