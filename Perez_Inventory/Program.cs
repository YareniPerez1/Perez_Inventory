// Yareni Perez
//IT112
// Notes: I know there is a better way to calculate the total cost, I just couldn't figure out how to do any math before they commpute charges.
namespace Perez_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shipper itemadded = new Shipper();
            do
            {

                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1.Add a Bicycle to the shipment");
                Console.WriteLine("2.Add a Lawn Mower to the shipment");
                Console.WriteLine("3.Add a Baseball Glove to the shipment");
                Console.WriteLine("4.Add Crackers to the shipment ");
                Console.WriteLine("5.List Shipment Items ");
                Console.WriteLine("6.Compute Shipping Charges ");
               
                decimal choice = decimal.Parse(Console.ReadLine());
                itemadded.AddedShippedAmounts(choice);

                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine(itemadded.Add(new Bicycles()));
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadKey(true);
                }
                if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine(itemadded.Add(new LawnMower()));
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadKey(true);
                }
                if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine(itemadded.Add(new BaseballGloves()));
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadKey(true);
                }
                if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine(itemadded.Add(new Crackers()));
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadKey(true);
                }

                if (choice == 5)
                {
                    Console.Clear();
                    Console.WriteLine(itemadded.list());
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadKey(true);
                    
                }

                if (choice == 6)
                {
                    
                    Console.WriteLine("Your total is: " +itemadded.AddedAmount.ToString("C"));
                    Console.WriteLine("Press any key to exit the application");
                   Console.ReadKey(true);
                    break;
               
                }
               

                





              

            } while (true);
     
        }
    }
}