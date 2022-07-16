namespace Banca.API.User
{
    public class User
    {
        public User() { }
        public User(string cpf, string email)
        {
            this.CPF = cpf;
            this.Email = email;
        }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}