using System.Text;
using System.Text.RegularExpressions;

namespace StringHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "expens.txt";
            StringBuilder sb = new StringBuilder($" --------------------------------------\n" +
                                                 $"| {"Expense",-10} | {"Amount",-10} | {"Date",-10} |\n" +
                                                 $" --------------------------------------\n");
            do
            {
                Console.Write("Expense name: ");
                string str = Console.ReadLine();

                Console.Write("Amount: ");
                double amount = double.Parse(Console.ReadLine());

                Console.Write("Date (15:29): ");
                TimeSpan time = TimeSpan.Parse(Console.ReadLine());

                Console.Write("\n\n");
                Console.Write("Hit enter to add expense...");

                string Stop = Console.ReadLine();

                if (string.IsNullOrEmpty(Stop))
                {
                    sb.AppendFormat($"| {str,-10} | {amount,-10} | {time,-10} |\n" +
                                    $" --------------------------------------\n");
                }
                else if (Regex.IsMatch(Stop, "stop", RegexOptions.IgnoreCase))
                {
                    break;
                }
            } while (true);
            try
            {
                File.WriteAllText(path, sb.ToString());
                Console.WriteLine("Filega yozib qoyildi...");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
