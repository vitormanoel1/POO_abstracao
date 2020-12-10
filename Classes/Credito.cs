namespace POO_Abstracao.Classes
{
    public class Credito : Cartao
    {
        public double porcentagem;
        public double valores;
        public int parcelas;
        public float limite = 3000;
        public void Pagar(float Valor){
             if(parcelas <= 6) {
                porcentagem = 0.05;
            } else if(parcelas >= 7 && parcelas <= 12) {
                porcentagem = 0.08;
            }
        }
    }
}