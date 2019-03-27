using System;
using System.Security.Cryptography;
using System.Text;

namespace UrhoSharp.Editor.Model
{
    public class MD5HashFunction : IHashFunction, IDisposable
    {
        private readonly MD5 _md5Hash;

        public MD5HashFunction()
        {
            _md5Hash = MD5.Create();
        }

        public void Dispose()
        {
            _md5Hash.Dispose();
        }

        public string GetHash(string input)
        {
            return GetHash(Encoding.UTF8.GetBytes(input));
        }

        public string GetHash(byte[] input)
        {
            // Convert the input string to a byte array and compute the hash.
            var data = _md5Hash.ComputeHash(input);

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (var i = 0; i < data.Length; i++) sBuilder.Append(data[i].ToString("x2"));

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}