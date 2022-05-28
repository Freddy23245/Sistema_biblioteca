using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Capa_Logica
{
    public class Seguridad
    {
        public string SHA1Encrypt(string password)
        {
            System.Security.Cryptography.HashAlgorithm hashValue = new
           System.Security.Cryptography.SHA1CryptoServiceProvider();

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);

            byte[] byteHash = hashValue.ComputeHash(bytes);

            hashValue.Clear();

            return (Convert.ToBase64String(byteHash));
        } 
    }
}
