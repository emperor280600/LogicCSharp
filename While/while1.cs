namespace While
{
    internal class while1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            while (senha != "S4laFic4r3m51lenc10")
            {
                console.writeline("Senha incorreta. Tente novamente: ");
                Console.WriteLine("Digite a senha: ");
                senha = Console.ReadLine();
            }
            Console.WriteLine("acesso liberado.");
        }
    }
}
