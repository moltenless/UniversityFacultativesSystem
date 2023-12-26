namespace UniversityFacultativesDAL.Entity
{
    public struct UserLogin
    {
        public int UserId {  get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserLogin(int userId, string login, string password)
        {
            UserId = userId;
            Login = login;
            Password = password;
        }
    }
}
