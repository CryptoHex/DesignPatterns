using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class DecryptorAdapter : IDecryptor
    {
        private Decryptor decryptor;

        public DecryptorAdapter()
        {
            this.decryptor = new Decryptor();
        }

        public string Decrypt(string message)
        {
            return decryptor.Decrypt(message);
        }
    }
}
