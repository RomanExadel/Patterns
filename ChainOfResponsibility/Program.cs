namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var visaPresident = new VicePresident();
            var president = new President();

            director.SetSuccessor(visaPresident);
            visaPresident.SetSuccessor(president);

            director.ProcessRequest(new Purchase(10000, 55000, "Project X"));
        }
    }
}
