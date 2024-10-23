using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6221
{
    class Program
    {
         static void Main()
    {
        Dictionary<string, decimal> budget = new Dictionary<string, decimal>();


        decimal monthlyIncome = Read("Enter monthly income: ");
        decimal monthlyTax = Read("Enter estimated montly tax: ");
        decimal groceries = Read("Enter estimated monthly expenditures for groceries: ");
        decimal water = Read("Enter estimated monthly expenditures for water: ");
        decimal lights = Read("Enter estimated monthly expenditures for lights: ");
        decimal traveling = Read("Enter estimated monthly expenditures for traveling: ");
        decimal other = Read("Enter other expenses: ");


        decimal income = monthlyIncome - monthlyTax;
     
        budget.Add("Groceries", groceries);
        budget.Add("Water", water);
        budget.Add("Lights", lights);
        budget.Add("Traveling", traveling);
        budget.Add("Other", other);


        Console.WriteLine("Do you wanna buy a vehicle? Y/N");
        if (Console.ReadLine().ToLower() == "y")
        {
            decimal price = Read("Enter price of vehicle: ");
            decimal deposit = Read("Enter total deposit: ");
            decimal interestRate = Read("Enter interest rate(%): ");
            decimal insurance = Read("Enter price of insurance: ");


            decimal pricePerMonth = price * interestRate / 100 / (5 * 12) + (5 * insurance) + deposit;


            budget.Add("Car", pricePerMonth);
            Console.WriteLine("Your income per months: {income}");
            Console.WriteLine(string.Join("\n", budget.OrderByDescending(x => x.Value).Select(x => "{x.Key}: {x.Value}")));


            if (pricePerMonth > (income / 3 * 4))
            {
                Console.WriteLine("This car is too exspensive!");
            }
        }
    }


    private static decimal Read(string message)
    {
        Console.Write(message);
        return decimal.Parse(Console.ReadLine());
    }
    }
}
