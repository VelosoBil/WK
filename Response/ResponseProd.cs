using WK.Interface;

namespace WK.Response
{
    public class ResponseProd : IEWK
    {
        public string descricao { get; set; }
        public string cfop { get; set; }
        public double valorcompra { get; set; }
        public double valorvenda { get; set; }
        public decimal comissao { get; set; }
        public int gruposprod { get; set; }
        public string imobilizado { get; set; }
        public int subgrupo { get; set; }
        public float tributoperc { get; set; }
        public double tributoval { get; set; }
        public float st { get; set; }
        public double stvalor { get; set; }
        public float dificmspercentual { get; set; }
        public double dificmsValor { get; set; }
        public double media { get; set; }
        public int centrocusto { get; set; }
    }
}
