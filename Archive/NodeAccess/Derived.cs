namespace NodeAccess
{
    public class Derived : Base
    {
        Base prevNode = new Base();
        Base nextNode = new Base();

        public void ResetValue()
        {
            number = 0;
        }
    }
}