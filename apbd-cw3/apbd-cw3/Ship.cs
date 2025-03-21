namespace apbd_cw3;

public class Ship
{
    private List<Container> containers;
    private double knots;
    private int maxContainers;
    private double maxWeight;
    private double currentWeight;

    public Ship(double knots, int maxContainers, double maxWeight)
    {
        this.containers = new List<Container>();
        this.knots = knots;
        this.maxContainers = maxContainers;
        this.maxWeight = maxWeight;
        this.currentWeight = 0;
    }

    public void AddContainer(Container container)
    {
        if (currentWeight + container.InWeight <= maxWeight*1000)
        {
            currentWeight += container.InWeight;
            containers.Add(container);
        }
        else
        {
            Console.WriteLine("WARNING: Too much weight");
        }
        
    }

    public void AddContainers(List<Container> containers)
    {
        foreach (Container c in containers)
        {
            if (currentWeight + c.InWeight <= maxWeight * 1000)
            {
                currentWeight += c.InWeight;
                this.containers.Add(c);
            }
            else
            {
                Console.WriteLine("WARNING: Too much weight");
            }
        }
    }
}