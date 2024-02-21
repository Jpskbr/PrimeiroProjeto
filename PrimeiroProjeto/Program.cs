namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string nome; 
            int idade;
            string cidade;

            Console.WriteLine("digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite Sua Idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Qual é a sua cidade: ");
            cidade = Console.ReadLine();
           
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("Idade:{0}", idade); 
            Console.WriteLine("Cidade:{0}", cidade);
           // Console.WriteLine("Nome:{0}\nIdade: {1}\nCidade: {2}\n", nome, idade, cidade);
        }
    }
}