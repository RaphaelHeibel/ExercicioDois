
namespace ExercicioDois
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Atleta = string.Empty;
            List<double> ListaSaltos = new();
            double media, resp;
            Console.WriteLine("Digite o nome do atleta: ");
            Atleta = Console.ReadLine();
            while (Atleta != "" || Atleta != string.Empty)
            {
                int count = 0;

                Console.WriteLine("Primeiro salto: \n");
                ListaSaltos.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Segundo salto: \n");
                ListaSaltos.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Terceiro salto: \n");
                ListaSaltos.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Quarto salto: \n");
                ListaSaltos.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Quinto salto: \n");
                ListaSaltos.Add(Convert.ToDouble(Console.ReadLine()));

                foreach (var item in ListaSaltos)
                {
                    count++;

                    switch (count)
                    {
                        case 1:
                            Console.WriteLine($"Primeiro salto: {item}\n");
                            break;
                        case 2:
                            Console.WriteLine($"Segundo salto: {item}\n");
                            break;
                        case 3:
                            Console.WriteLine($"Terceiro salto: {item}\n");
                            break;
                        case 4:
                            Console.WriteLine($"Quarto salto: {item}\n");
                            break;
                        case 5:
                            Console.WriteLine($"Quinto salto: {item}\n");
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine($"Melhor Salto: {ListaSaltos.Max()}\n");
                Console.WriteLine($"Pior Salto: {ListaSaltos.Min()}\n");

                ListaSaltos.Remove(ListaSaltos.Min());
                ListaSaltos.Remove(ListaSaltos.Max());

                media = ListaSaltos.Average();
                 Console.WriteLine($"Média dos demais saltos: {media}");

                Console.WriteLine("Resultado Final: \n");
                Console.WriteLine($"{Atleta}  : {media} \n");

                Console.WriteLine("Digite o nome do atleta: ");
                Atleta = Console.ReadLine();
            }
        }
    }
}