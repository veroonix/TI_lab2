using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Key
    {
        public static BitArray key = new BitArray(0);
        public static StringBuilder regstate = new StringBuilder();
        public static int ind = 0;
        public static BitArray generateKey(BitArray regState, int bitsCount)
        { 
            Key.key = new BitArray(bitsCount);
            ind = 0;
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < bitsCount; i++)
            {
                regState = ShiftLeft(regState, ref key, i);
                foreach (bool bit in regState)
                {
                    temp.Append(bit ? "1" : "0"); // Если бит true — добавляем "1", иначе — "0"
                }
                temp.Append('\n');
            }
            regstate = temp;

            return key;
        }

        public static BitArray ShiftLeft(BitArray regState, ref BitArray key, int ind)
        {
            BitArray newRegState = new BitArray(regState.Length);
            bool keyState = regState[0];
            // AddToBitArray(key, keyState, ind);
            key[ind] = keyState;
            int len = regState.Length;
            bool xorbits = regState[0] ^ regState[len - 2] ^ regState[len - 12] ^ regState[len - 10];
            for (int i = 0; i < regState.Length - 1; i++)
            {
                newRegState[i] = regState[i + 1];
            }
            newRegState[regState.Length - 1] = xorbits;
            return newRegState;
        }

    }
}
