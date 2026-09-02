namespace CSharp1
{
    internal class sequencia
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual é o seu nome? ");                              //string nome = "Arthur";

            string nome = Console.ReadLine();                                    //int idade = 15;
            Console.WriteLine("qual é a sua idade? ");                          //Console.WriteLine("Nome: " + nome);

            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("olá, " + nome + " ! Você tem " + idade + " anos. ");    //Console.WriteLine("idade: " + idade);
        }
    }
}
