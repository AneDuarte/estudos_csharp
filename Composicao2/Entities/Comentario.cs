namespace Composicao2.Entities
{
    public class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        {

        }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}