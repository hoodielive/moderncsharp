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

    public void Process()
    {
        foreach (var item in Items)
        {
            if (item is Trash)
            {
                SmartIncinerator.Burn((Trash)item);

            }
            else if (item is Bottle)
            {
                Melter.MakeFidgetSpinner((Bottle)item);
            }
            else if (item is Soda)
            {
                Sponge.SoakUp((Soda)item);
            }
            else if (item is Food)
            {
                Composter.GrowKale((Food)item);
            }
        }
    }
}