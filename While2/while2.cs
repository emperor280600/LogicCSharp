namespace While2
{
    internal class while2
    {
        static void Main(string[] args)
        {   
                     Console.WriteLine("Digite  um comando (ou 'sair' para encerrar)");
                     string comando = Console.ReadLine();

                     while (comando != "sair")
            {
                     Console.WriteLine("Você digitou: " + comando);
                     Console.WriteLine("Digite um comando (ou 'sair' para encerrar)");
                     comando = Console.ReadLine();
            }
                     Console.WriteLine("programa encerrado.");
        }
    }
}
