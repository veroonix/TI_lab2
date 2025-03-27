using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class streamCipher
    {
        public static BitArray encrypt(BitArray plainText, BitArray key)
        {
            BitArray ciphertext = key.Xor(plainText);
            return ciphertext;
        }

        public static BitArray decrypt(BitArray cipherText, BitArray key)
        {
            BitArray plaintext = key.Xor(cipherText);
            return plaintext;
        }
    }
}
