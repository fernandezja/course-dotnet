using System.Text;
using System.Security.Cryptography;

namespace PasswordHash
{
    public static class PasswordHashManager
    {
        public static string HashPassword(string password, byte[] salt)
        {
          
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                // Concatenar password y salt
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                //Hashear la concatenacion de password y salt
                byte[] hashedBytes = SHA256.HashData(saltedPassword);

                //concatenar el salt y el password hasheado para almacenar
                byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

                return Convert.ToBase64String(hashedPasswordWithSalt);
           
        }

        public static byte[] GenerateSalt()
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return salt;
            }
        }
    }
}
