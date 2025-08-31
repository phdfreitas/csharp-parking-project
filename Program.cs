using Model.Estacionamento;

Console.WriteLine("Bem-vindo ao estacionamento C#");
Console.WriteLine("Antes de qualquer coisa, informe o preço inicial e preço por hora no estacionamento.");

Console.WriteLine("Preço inicial: ");
decimal precoInicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("Preço por hora: ");
decimal precoPorHora = decimal.Parse(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

Console.WriteLine("Obrigado!!\nNo dia de hoje é possível fazer as seguintes operações:\n");
Console.WriteLine("1. Cadastrar veículo\n2. Remover veículo\n3. Listar veículo\n");

int operacao = 0;

do
{
    Console.WriteLine("Informe o número da operação que deseja fazer. [ou digite 4 para sair do programa]");
    operacao = int.Parse(Console.ReadLine());

    switch (operacao)
    {
        case 1:
            estacionamento.AdicionarVeiculo();
            break;
        case 2:
            estacionamento.RemoverVeiculo();
            break;
        case 3:
            estacionamento.ListarVeiculos();
            break;
        case 4:
            Console.WriteLine("Obrigado por utilizar o Estacionamento C#\nAté a próxima!!");
            break;
        default:
            Console.WriteLine("Essa não é uma opção válida. Tente novamente.");
            break;
    }
} while (operacao != 4);
