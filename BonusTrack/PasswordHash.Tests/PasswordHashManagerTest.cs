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
        public void HashPassword_Test()
        {
            var saltHex = "B9++mcceb8aoJSyCavMGVw==";
            var salt = Convert.FromBase64String(saltHex);


            var hashHex = PasswordHashManager.HashPassword("Demo123456", salt);

            Assert.NotNull(hashHex);
            Assert.Equal("B9++mcceb8aoJSyCavMGVzwBpHqhZP6T3qof4gYw8MzjSSDes10dVP4Fx40s8rep", hashHex);
        }


        [Theory]
        [InlineData("B9++mcceb8aoJSyCavMGVw==", "B9++mcceb8aoJSyCavMGVzwBpHqhZP6T3qof4gYw8MzjSSDes10dVP4Fx40s8rep")]
        [InlineData("k/xIkUIpPvJWfRakYWEwFA==", "k/xIkUIpPvJWfRakYWEwFE9YIUATsllPjd68l7fpeFy3GTB+SML9lhauEG4kdXRi")]
        public void HashPassword_Multiple_Test(string saltHex, string hashHexExpected)
        {
            var salt = Convert.FromBase64String(saltHex);


            var hashHex = PasswordHashManager.HashPassword("Demo123456", salt);

            Assert.NotNull(hashHex);
            Assert.Equal(hashHexExpected, hashHex);
        }
    }
}