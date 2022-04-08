using System.Text;

namespace MiniEcommerce.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDate { get; set; }

        public Client()
        {

        }
        public Client(string name, string email, DateOnly birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} - {BirthDate.ToString("dd/MM/yyyy")} - {Email}");
            return sb.ToString();
        }
    }
}