using System.Text;
using System.Security.Cryptography;

namespace PasswordHash
{
    public static class PasswordHashManager
    {
        public static byte[] HashPassword1(string password, byte[] salt)
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

                return hashedPasswordWithSalt;
           
        }


        public static byte[] HashPassword2(string password, byte[] salt)
        {

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

            // Concatenar password y salt
            Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
            Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

            //Hashear la concatenacion de password y salt
            byte[] hashedBytes = SHA256.HashData(saltedPassword);

            return hashedBytes;

        }



        public static string HashPassword1Hex(string password, byte[] salt)
        {
            return Convert.ToBase64String(HashPassword1(password, salt));

        }


        public static string HashPassword2Hex(string password, byte[] salt)
        {
            return Convert.ToBase64String(HashPassword2(password, salt));

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
