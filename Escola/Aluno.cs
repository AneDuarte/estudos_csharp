namespace Escola
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Aprovacao()
        {
            if (Media() >= 60)
            {
                return "APROVADO!";
            }
            else
            {
                double final = 60 - Media();
                return "REPROVADO! Pontos para passar: " + final;
            }
        }
    }
}