namespace CUM.Domain.Entities
{
    public class UserRequest
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailConfirmed { get; set; }
        public string Password { get; set; }



        //public int UserId { get; set; } = 0;
        //public string UserName { get; set; } = "TestUser";
        //public string FirstName { get; set; } = "John";
        //public string MiddleInitial { get; set; } = "J";
        //public string LastName { get; set; } = "Smith";
        //public string Email { get; set; } = "jsmith@testing.com";
        //public string EmailConfirmed { get; set; } = "jsmith@testing.com";
        //public string Password { get; set; } = "P@ssw0rd";

    }
}