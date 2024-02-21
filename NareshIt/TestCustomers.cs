namespace NareshIt
{
    internal class TestCustomers
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101, false, "JOHN", 5000.000);
            Console.WriteLine("CustomerId: " + obj.CustId);
            obj.CustId = 102;
            Console.WriteLine("After Change: " + obj.CustId);
            Console.ReadLine();
        }
    }
}
