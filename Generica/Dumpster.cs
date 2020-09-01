using System.Collections; 
using System.Collections.Generic; 

public class Dumpster
{
    public IList Foods { get; } = new ArrayList(); 
    public IList Waste { get; } = new ArrayList(); 
    public IList Bottles { get; } = new ArrayList(); 
    public IList Liquids { get; } = new ArrayList(); 

    public void Dispose(params object[] dispose)
    {
        foreach(var item in dispose)
        {
            Items.Add(item);
        }
    }

    public void Process(IList items)
    {
        foreach (var item in Items)
        {
            if (item is Trash)
            {
                Waste.Add(item);

            }
            else if (item is Bottle)
            {
                Bottles.Add(item);
            }
            else if (item is Soda)
            {
                Bottles.Add(item);
            }
            else if (item is Food)
            {
                Foods.Add(item);
            }
        }
    }
}