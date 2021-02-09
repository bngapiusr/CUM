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


    }
}