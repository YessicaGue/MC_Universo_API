using System.Security.Cryptography;
using System.Text;

namespace MC_Universo_API.Utils;

public class EncryptCustom
{
    public static string Encrypt(string password)
    {
        // Encrypt the password using SHA512
        var hashedBytes = SHA512.HashData(Encoding.UTF8.GetBytes(password));
        var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        return hash;
    }

    // Compare two hashes
    public static bool Compare(string hash1, string hash2)
    {
        return hash1 == hash2;
    }
}