using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface IDecryptor
    {
       string Decrypt(string message );
    }
}
