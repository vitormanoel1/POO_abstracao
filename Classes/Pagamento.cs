
using System;
namespace POO_Abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;
        public string cancelar(){
            return "";
        }
        public abstract string Desconto(int valor);
        protected abstract string Juros(int parcelas);
    }
}