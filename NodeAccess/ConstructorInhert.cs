namespace NodeAccess
{
    public class ConstructInherit : ConstructBase(0)
    {
        
        public int X { get; set; }
        public int Y { get; set; }
        public ConstructInherit() : base(0)
        {
            
        }

        public ConstructInherit(int x) : base(x)
        {
            
        }

        public ConstructInherit(int x, int y) : base(x, y)
        {
           // Constructor with two parameters. 
           int X = x;
           int Y = y;
        }
    }
    
}