using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieMauiAPI.Models;

namespace FilmFinderApi.Data
{
    public class SeedDataTestUser : IEntityTypeConfiguration<UserModel>
    {

        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "password"!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            builder.HasData(new UserModel
            {
                UserId = 1,
                Username = "test user",
                TempPassword = "P@ssw0rd",
                PasswordHash = hashed,
                CreateDate = DateTime.Now.Date
            });
            builder.HasData(new UserModel
            {
                UserId = 2,
                Username = "test user 2",
                TempPassword = hashed,
                PasswordHash = hashed,
                CreateDate = DateTime.Now.Date
            });
        }

    }
}