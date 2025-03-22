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
        if (currentWeight + container.InWeight + container.OutWeight <= maxWeight*1000)
        {
            currentWeight += container.InWeight + container.OutWeight;
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
            if (currentWeight + c.InWeight + c.OutWeight <= maxWeight * 1000)
            {
                currentWeight += c.InWeight + c.OutWeight;
                this.containers.Add(c);
            }
            else
            {
                Console.WriteLine("WARNING: Too much weight");
            }
        }
    }

    public void RemoveContainer(Container container)
    {
        this.containers.Remove(container);
        this.currentWeight -= container.InWeight + container.OutWeight;
        Console.WriteLine("Removed container: " + container.Name);
    }

    public void ReplaceContainer(Container c1, Container c2)
    {
        if (currentWeight - c1.InWeight - c1.OutWeight + c2.InWeight + c2.OutWeight <= maxWeight * 1000)
        {
            RemoveContainer(c1);
            this.containers.Add(c2); 
            this.currentWeight += c2.InWeight + c2.OutWeight;
            Console.WriteLine("Contaier " + c1.Name + " replaced with " + c2.Name);
        }
        else
        {
            Console.WriteLine("WARNING: Too much weight");
        }
        
    }

    public void ExchangeContainer(Ship s, Container c)
    {
        if (s.currentWeight + c.InWeight + c.OutWeight <= s.maxWeight * 1000)
        {
            this.RemoveContainer(c);
            s.containers.Add(c);
            s.currentWeight += c.InWeight + c.OutWeight;
            Console.WriteLine("Container " + c.Name + " has been transported.");
        }
        else
        {
            Console.WriteLine("WARNING: Too much weight");
        }
        
    }

    public void ShowInfo()
    {
        Console.WriteLine("Knots: " + this.knots +
                          "\nMax Containers: " + this.maxContainers +
                          "\nMax Weight: " + this.maxWeight +
                          "\nCurrent Weight: " + this.currentWeight);
        Console.WriteLine("Containers: ");
        foreach (Container c in containers)
        {
            c.ShowInfo();
        }
    }
}