using System;
using Sistema_para_estacionamento_com_c_.Estacionamento;  // Importe o namespace do Estacionamento

class Program
{
    static bool Exibir_menu = true;
    static double Preco = 10;

    static void SolicitarPreco()
    {
        Console.WriteLine("Digite o novo valor do preço:");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double novoPreco))
        {
            Preco = novoPreco;
            Console.WriteLine($"O preço definido: {Preco}");
        }
        else
        {
            Console.WriteLine("Valor inválido. O preço será mantido como 10.");
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("Digite: ");
        Console.WriteLine("1. Cadastrar novo carro");
        Console.WriteLine("2. Remover carro");
        Console.WriteLine("3. Listar carros");
        Console.WriteLine("4. Limpar cmd");
        Console.WriteLine("5. Encerrar o dia");
    }

    static void CadastrarCarro()
    {
        Console.WriteLine("Digite a placa:");
        string placa = Console.ReadLine();
        Console.WriteLine("Digite o modelo:");
        string modelo = Console.ReadLine();

        Carro novoCarro = new Carro(placa, modelo);
        Estacionamento.AddCarro(novoCarro);
        ListarCarros();
    }

    static void CalcularDinheiro(Carro c)
    {
        DateTime atual = DateTime.Now;
        TimeSpan horaC = c.GetDataHora().TimeOfDay;
        double minutosDecorridos = (atual - atual.Date).TotalMinutes - horaC.TotalMinutes;
        double vlr = Preco * minutosDecorridos;
        Console.WriteLine($"Valor pago = {vlr}");
    }

    static void RemoverCarro()
    {
        Console.WriteLine("Digite a placa do carro que deseja remover:");
        string placa = Console.ReadLine();

        List<Carro> carrosParaRemover = new List<Carro>();

        foreach (Carro c in Estacionamento.Carros)
        {
            if (string.Equals(c.GetPlaca(), placa, StringComparison.OrdinalIgnoreCase))
            {
                carrosParaRemover.Add(c);
                CalcularDinheiro(c);  // Chama o método para calcular o valor pago
            }
            else
            {
                Console.WriteLine($"O carro com placa {c.GetPlaca()} não será removido.");
            }
        }

        foreach (Carro carroRemover in carrosParaRemover)
        {
            Estacionamento.RemoverCarro(carroRemover);  // Chama o método estático RemoverCarro diretamente na classe Estacionamento
        }
    }

    static void ListarCarros()
    {
        Console.WriteLine("Lista de carros no estacionamento:");
        foreach (Carro c in Estacionamento.Carros)
        {
            Console.WriteLine(c.ToString());
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao estacionamento");
        Estacionamento es = new Estacionamento("Teste", Preco);
        SolicitarPreco();

        bool exibirMenu = true;
        while (exibirMenu)
        {
            ExibirMenu();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CadastrarCarro();
                    break;

                case "2":
                    RemoverCarro();
                    break;

                case "3":
                    ListarCarros();
                    break;

                case "4":
                    Console.Clear();
                    break;

                case "5":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    break;
            }
        }
    }
}
