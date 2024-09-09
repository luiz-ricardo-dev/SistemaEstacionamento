//Aplicação Simples para um sistema de estacionamento no C#
//Aut. Luiz Ricardo de Campos

//Declaração de variaveis
List<string> carros = new List<string>();
string opcao = "";
bool exit = true;
string addCarro;
string rmvCarro;
decimal preco = 0;
int valorHoras = 0;
int qntHoras = 0;

//Recebendo o valores para calculo
Console.WriteLine("Bem Vindo ao Sistema de estacionamento!");

Console.WriteLine("Digite o valor inicial: ");
preco = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor Por Hora: ");
valorHoras = Convert.ToInt32(Console.ReadLine());
Console.Clear();

//Menu da Aplicação
while(exit)
{
Console.WriteLine("Selecione uma das opçôes abaixo: ");
Console.WriteLine("1 - CADASTRAR VEÍCULO");
Console.WriteLine("2 - REMOVER VEÍCULO");
Console.WriteLine("3 - LISTAR VEÍCULOS");
Console.WriteLine("4 - ENCERRAR");

opcao = Console.ReadLine();

//Realizando as opções selecionadas
switch (opcao)
{
    case "1":
        Console.WriteLine("Digite a placa do carro: ");
        addCarro = Console.ReadLine(); 
        carros.Add(addCarro);
        break;
    case "2":
        Console.WriteLine("Digite a placa do carro para remover: ");
        rmvCarro = Console.ReadLine(); 
        carros.Remove(rmvCarro);
        Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");
        qntHoras = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O veículo {rmvCarro} foi removido e o preço total foi de: {preco + (qntHoras * valorHoras)} Reais");
        break;
    case "3":
        Console.WriteLine("Veículos estacionados: ");
        foreach (string i in carros){
            Console.WriteLine(i);
        }
        break;
    case "4":
        Console.WriteLine("Encerrado..");
        exit = false;
        break;
    default:
        Console.WriteLine("Opção Invalida!");
        break;
    
}
}