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

    public void AddContainers(List<Container> containersList)
    {
        foreach (Container c in containersList)
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

    public void removeContainer(Container container)
    {
        this.containers.Remove(container);
    }

    public void replaceContainer(Container c1, Container c2)
    {
        removeContainer(c1);
        this.containers.Add(c2);
    }

    public void exchangeContainer(Ship s, Container c)
    {
        this.containers.Remove(c);
        s.containers.Add(c);
    }

    public void showInfo()
    {
        Console.WriteLine("Knots: " + this.knots +
                          "\nMax Containers: " + this.maxContainers +
                          "\nMax Weight: " + this.maxWeight +
                          "\nCurrent Weight: " + this.currentWeight);
        Console.WriteLine("Containers: ");
        foreach (Container c in containers)
        {
            c.showInfo();
        }
    }
}