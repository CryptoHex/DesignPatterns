using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Decryptor : IDecryptor
    {
        public string Decrypt(string code)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < code.Length; i+=4)
            {
                sb.Append(code[i]);
            }

            return sb.ToString();
        }
    }
}
