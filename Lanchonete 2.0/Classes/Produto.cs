namespace Lanchonete_2._0.Classes
{
    internal class Produto
    {
        public string Nomep { get; set; }
        public string Descp { get; set; }
        public double Precop { get; set; }
        public Produto() { }
        public Produto(string nomep, string descp, double precop)
        {
            Nomep = nomep;
            Descp = descp;
            Precop = precop;
        }
    }
}
