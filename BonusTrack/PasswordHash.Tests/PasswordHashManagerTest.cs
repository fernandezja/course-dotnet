namespace PasswordHash.Tests
{
    public class PasswordHashManagerTest
    {

        [Fact]
        public void GenerateSalt_Test()
        {
            var salt = PasswordHashManager.GenerateSalt();
            var saltHex = Convert.ToBase64String(salt);

            Assert.NotNull(salt);
            Assert.NotNull(saltHex);
        }
        


        [Fact]
        public void HashPassword1_Test()
        {
            var saltHex = "B9++mcceb8aoJSyCavMGVw==";
            var salt = Convert.FromBase64String(saltHex);


            var hash = PasswordHashManager.HashPassword1("Demo123456", salt);

            var hashHex = Convert.ToBase64String(hash);

            Assert.NotNull(hashHex);
            Assert.Equal("B9++mcceb8aoJSyCavMGVzwBpHqhZP6T3qof4gYw8MzjSSDes10dVP4Fx40s8rep", hashHex);
        }


        [Fact]
        public void HashPassword2_Test()
        {
            var saltHex = "B9++mcceb8aoJSyCavMGVw==";
            var salt = Convert.FromBase64String(saltHex);


            var hash = PasswordHashManager.HashPassword2("Demo123456", salt);

            var hashHex = Convert.ToBase64String(hash);

            Assert.NotNull(hashHex);
            Assert.Equal("PAGkeqFk/pPeqh/iBjDwzONJIN6zXR1U/gXHjSzyt6k=", hashHex);
        }




        [Theory]
        [InlineData("B9++mcceb8aoJSyCavMGVw==", "B9++mcceb8aoJSyCavMGVzwBpHqhZP6T3qof4gYw8MzjSSDes10dVP4Fx40s8rep")]
        [InlineData("k/xIkUIpPvJWfRakYWEwFA==", "k/xIkUIpPvJWfRakYWEwFE9YIUATsllPjd68l7fpeFy3GTB+SML9lhauEG4kdXRi")]
        public void HashPassword1_Multiple_Test(string saltHex, string hashHexExpected)
        {
            var salt = Convert.FromBase64String(saltHex);

            var hashHex = PasswordHashManager.HashPassword1("Demo123456", salt);

            Assert.NotNull(hashHex);
            //Assert.Equal(hashHexExpected, hashHex);
        }



        [Theory]
        [InlineData("Demo123456", "B9++mcceb8aoJSyCavMGVw==", "B9++mcceb8aoJSyCavMGVzwBpHqhZP6T3qof4gYw8MzjSSDes10dVP4Fx40s8rep")]
        public void VerifyPassword_Test(string password, string saltHex, string hashHexExpected)
        {
            //From DB
            var saltFromDb = Convert.FromBase64String(saltHex);
            var hashHexFromDb = hashHexExpected;


            var hashHexToVerify = PasswordHashManager.HashPassword1Hex(password, saltFromDb);

            var isValid = (hashHexFromDb == hashHexToVerify);

            Assert.True(isValid);
        }
    }
}