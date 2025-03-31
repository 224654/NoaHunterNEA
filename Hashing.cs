using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*
namespace NoaHunterNEA
{
    internal class Hashing
    {
        public Hashing()
        {
            System.Security.Cryptography.SHA256CryptoServiceProvider SHA256 = new System.Security.Cryptography.SHA256CryptoServiceProvider();
            byte[] byteArray = SHA256.ComputeHash(Encoding.UTF8.GetBytes("Hello"));

            string hexDigest = "";
            foreach (byte b in byteArray)//using b instead of 'byte' as a variable name as byte is reserved
            {
                hexDigest = hexDigest + b.ToString("X");//hex form
            }
        }



        /*public string DoHash(string text)
        {
            string hash = "";
            System.Security.Cryptography.SHA256CryptoServiceProvider ALGore = new System.Security.Cryptography.SHA256CryptoServiceProvider();
            hash = ALGore.ComputeHash(text);
            return "";
        }

    }

    //https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/compute-hash-values#summary
}
*/