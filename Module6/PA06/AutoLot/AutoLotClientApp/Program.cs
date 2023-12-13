/*
 * Name: Aidan Linerud
 * Date: 11/1/2023
 * Assignment: PA06-3
 */

using AutoLotDAL.DataOperations;

using static System.Console;

namespace AutoLotClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dal = new InventoryDal();
            var list = dal.GetAllInventory();

            WriteLine("Cars:");
            PrintInventory(list);

            dal.InsertAuto("Blue", 5, "TowMonster");
            list = dal.GetAllInventory();

            WriteLine("Cars with new TowMonster inserted:");
            PrintInventory(list);

            var newCar = list.First(car => car.PetName == "TowMonster");

            if (newCar != null)
            {
                var petName = dal.LookUpPetName(newCar.Id);
                WriteLine($"PetName from Id {newCar.Id}: {petName}");
                WriteLine();

                dal.DeleteCar(newCar.Id);
                list = dal.GetAllInventory();

                WriteLine("Cars after TowMonster deleted:");
                PrintInventory(list);
            }
        }

        static void PrintInventory(List<AutoLotDAL.Models.CarViewModel> list)
        {
            WriteLine("Id\tMake\tColor\tPet Name");
            foreach (var car in list)
                WriteLine($"{car.Id}\t{car.Make}\t{car.Color}\t{car.PetName}");
            WriteLine();
        }
    }
}