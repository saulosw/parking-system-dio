using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace training_cs.Models
{
    public class Parking
    {
        List<string> registeredVehicles = new List<string>();
        public void RegisterVehicle(string vehicle)
        {
            registeredVehicles.Add(vehicle);
        }

        public void RemoveVehicleAndCalculatePrice(string vehicle, int initialPrice, int hourPrice)
        {
            if (registeredVehicles.Contains(vehicle))
            {
                registeredVehicles.Remove(vehicle);
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado:");
                int parkHours = Convert.ToInt32(Console.ReadLine());
                CalculatePrice(vehicle, initialPrice, hourPrice, parkHours);
            }
            else
            {
                Console.WriteLine("Esse veiculo nao foi registrado!");
            }
        }

        public void ListAllVehicle()
        {
            foreach (string vehicle in registeredVehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        public void CalculatePrice(string vehicle, int initialPrice, int hourPrice, int hours)
        {
            int finalPrice = (hours * hourPrice) + initialPrice;
            Console.WriteLine($"O veiculo {vehicle} foi removido e o preco total foi de R${finalPrice}");
        }
    }
}