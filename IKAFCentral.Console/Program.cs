namespace IKAFCentral.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AFCentral; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            DataAccess.SqlServerAccess ssa = new DataAccess.SqlServerAccess(cs);

            
            System.Console.WriteLine("Please enter your First Name");

            var firstName = System.Console.ReadLine();

            System.Console.WriteLine("Please enter your Surname");

            var surname = System.Console.ReadLine();

            System.Console.WriteLine("Please enter your PrinterCode");

            var printerCode = System.Console.ReadLine();

            System.Console.WriteLine(ssa.ConnectToDb(firstName, surname, printerCode));

        }
    }
}
