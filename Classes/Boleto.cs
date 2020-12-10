
namespace POO_Abstracao.Classes
{
    public class Boleto : Pagamento
    {private string codigoDeBarras;
       public string CodigoDeBarras{
            get{return CodigoDeBarras;}
        }
        public void Registrar(string valor){
            this.codigoDeBarras = valor;
        }
        public double valores;
        public double porcentagem = 0.88;
        public int parcelas;
        public string resultado;
        public override string Desconto(int valor)
        {
            return "";
        }
        protected override string Juros(int parcelas)
        {
            return "";
        }
    }
}