namespace apbd_cw3;

public class CoolingContainer : Container
{
    public CoolingContainer(double inWeight, double height, double outWeight, double deepness, string name, double maxCapacity, ContainerType containerType) : 
        base(inWeight, height, outWeight, deepness, name, maxCapacity, containerType)
    {
        this.name = "KON-" + ContainerType.C.ToString() + "-" + new Random().Next().ToString();
    }
    
    
    
    
}