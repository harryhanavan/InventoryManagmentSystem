using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public enum UserRole
    {
        Administrator,
        Sales,
        InventoryManager
        // Add more roles as needed
    }
    public class User
    {
        public int UserID { get; private set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public UserRole Role { get; set; }

        private static string dataDirectory = "../../../Data/";
        private static string usersFilePath = Path.Combine(dataDirectory, "users.csv");

        public User(int userId, string username, string password, UserRole role)
        {
            UserID = userId;
            Username = username;
            Password = password;
            Role = role;
        }

        public static bool Login(string username, string password, List<User> users)
        {
            try
            {
                User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    Console.WriteLine($"Welcome, {username}!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during login: {ex.Message}");
                return false;
            }
        }
        public bool ValidatePassword(string passwordToValidate)
        {
            return passwordToValidate == Password;
        }
        public static void Logout()
        {
            Console.WriteLine("You have been logged out.");
            // You might want to add more functionality here, like clearing user sessions or redirecting to the login page.
        }
        public static List<User> LoadUsers()
        {
            return LoadUsers(usersFilePath);
        }
        public static List<User> LoadUsers(string filePath)
        {
            List<User> users = new List<User>();
            List<string[]> data = FileManager.ReadData(filePath);
            Console.WriteLine($"Number of records loaded: {data.Count - 1}"); // -1 to exclude header
            foreach (var record in data.Skip(1)) // Skipping the header
            {
                User newUser = new User(
                    userId: int.Parse(record[0]),
                    username: record[1],
                    password: record[2],
                    role: (UserRole)Enum.Parse(typeof(UserRole), record[3])
                );
                users.Add(newUser);
                Console.WriteLine($"Loaded user: {newUser.Username}"); // Outputting usernames
            }

            return users;
        }
        public string[] ToCSV()
        {
            return new string[]
            {
                 UserID.ToString(),
                 Username,
                 Password,
                 Role.ToString()
            };
        }
    }
}
