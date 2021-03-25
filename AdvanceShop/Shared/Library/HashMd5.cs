using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.Library
{
    public static class HashMd5
    {
        public static string GerarHash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        public static bool VerificarHash(MD5 hash,string input)
        {
            var senha = GerarHash(input);
            StringComparer compara = StringComparer.OrdinalIgnoreCase;
            if(0 == compara.Compare(senha, hash))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
