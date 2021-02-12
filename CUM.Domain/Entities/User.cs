namespace CUM.Domain.Entities
{
    public class User
    {
        public User()
        {
        }

        //public User(UserRequest userresult)
        //{
        //    UserId = userresult.UserId;
        //    UserName = userresult.UserName;
        //    FirstName = userresult.FirstName;
        //    MiddleInitial = userresult.MiddleInitial;
        //    LastName = userresult.LastName;
        //    Email = userresult.Email;
        //    EmailConfirmed = userresult.EmailConfirmed;
        //    Password = userresult.Password;
        //}


        public User(int userid, string username, string firstname, string middleInitial, string lastname, string email, string emailconfirmed,string password)
        {
            UserId = userid;
            UserName = username;
            FirstName = firstname;
            MiddleInitial = middleInitial;
            LastName = lastname;
            Email = email;
            EmailConfirmed = emailconfirmed;
            Password = password;
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