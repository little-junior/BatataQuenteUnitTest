using BQ = BatataQuente;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BQ.BatataQuente batata = new BQ.BatataQuente();

            var resultado = batata.Play(10);
        }
    }
}
