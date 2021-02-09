namespace CUM.Domain.Entities
{
    public class User
    {
        public User()
        {
        }

        public User(UserRequest userresult)
        {
            UserId = userresult.UserId;
            UserName = userresult.UserName;
            FirstName = userresult.FirstName;
            MiddleInitial = userresult.MiddleInitial;
            LastName = userresult.LastName;
            Email = userresult.Email;
            EmailConfirmed = userresult.EmailConfirmed;
            Password = userresult.Password;
        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailConfirmed { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}