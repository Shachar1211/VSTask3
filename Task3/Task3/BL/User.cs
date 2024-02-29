using System.Data;

namespace Task3.BL
{
    public class User
    {
        string firstName;
        string familyName;
        string email;
        string password;

        static List<User> Users = new List<User>();

        public User(string firstName, string familyName, string email, string password)
        {
            FirstName = firstName;
            FamilyName = familyName;
            Email = email;
            Password = password;
        }
        public User()
        {

        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public bool Insert()
        {
            if (!Users.Exists(user => user.Email == this.Email))
            {
                DBservices dbs = new DBservices();
                dbs.Insert(this);
                return true;
            }
            return false;
        }
        public List<User> Read()
        {
            DBservices dbs = new DBservices();
            return dbs.Read();
        }
        public int Update()
        {
                DBservices dbs = new DBservices();
                return dbs.Update(this);

        }
        public User LogIn()
        {
            DBservices dbs = new DBservices();
            return dbs.LogIn(this);
        }
    }
}
