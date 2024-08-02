using System.Reflection.Metadata;
using training_cs.Models;

Parking park = new Parking();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial:");
int initialPrice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o preço por hora:");
int hourPrice = Convert.ToInt32(Console.ReadLine());

while(true){
    Console.Clear();
    Console.WriteLine("1 - Cadastrar Veiculo\n2 - Remover Veiculo\n3 - Listar Veiculos\n4 - Encerrar");
    int userChoice = Convert.ToInt32(Console.ReadLine());
    switch(userChoice) {
        case 1:
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            string licensePlateToAdd = Console.ReadLine();
            park.RegisterVehicle(licensePlateToAdd);
            Console.WriteLine("Pressione alguma tecla para continuar:");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Digite a placa do veiculo para remover:");
            string licensePlateToRemove = Console.ReadLine();
            park.RemoveVehicleAndCalculatePrice(licensePlateToRemove, initialPrice, hourPrice);
            Console.WriteLine("Pressione alguma tecla para continuar:");
            Console.ReadLine();
            break;
        case 3:
            park.ListAllVehicle();
            Console.WriteLine("Pressione alguma tecla para continuar:");
            Console.ReadLine();
            break;
    }
    if (userChoice == 4){
        break;
    }
}