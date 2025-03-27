using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.IO;
using System.Xml;
using System.Security.Cryptography;

namespace lab2
{
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        public (bool, string) IsCorrect()
        {
            bool IsCorrect = false;
            string pattern = "[^01]";
            string input = regInput.Text;
            string filteredInput = Regex.Replace(input, pattern, string.Empty);

         /*   if (filteredInput != string.Empty)
            {
                MessageBox.Show("Ошибка: Ввод содержит недопустимые символы! Введите только 0 и 1.", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, input);
            } */

            if (filteredInput.Length < 37)
            {
                MessageBox.Show("Ошибка: Длина ввода должна быть не менее 37 символов.", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (false, input);
            }
            else
            {
                filteredInput = filteredInput.Substring(0, 37);
            }

            IsCorrect = true;
            return (IsCorrect, filteredInput);
        }
        BitArray plainText = new BitArray(0);
        int bitsCount;
        BitArray cipherText = new BitArray(0);
        string input = null;
        private void encryp_Click(object sender, EventArgs e)
        {
            BitArray key = new BitArray(plainText.Length);
            bool isCorrect = false;
            string registerState = null;
            (isCorrect, registerState) = IsCorrect();
            if (isCorrect)
            {
                
                // Преобразование в BitArray
                BitArray regState = new BitArray(registerState.Length);
                regState = ConvertFromString(registerState);
                //переводим в двоичку файл
                
                //генерим ключ
                //изменить вывод
                key = Key.generateKey(regState, plainText.Length);
                string keybits = BitArrayToStr(key);
                keyInput.Text = keybits;
                //запускаем шифрование
                cipherText = streamCipher.encrypt(plainText, key);
                string result = BitArrayToStr(cipherText);
                output.Text = result;
                //собрать файлик из бит
               
               // textBox1.Text = Key.regstate.ToString();
            }
        }
        public static string BitArrayToString(BitArray bits)
        {
            StringBuilder sb = new StringBuilder();
            foreach (bool bit in bits)
            {
                sb.Append(bit ? "1" : "0"); // Если бит true — добавляем "1", иначе — "0"
            }
            return sb.ToString();
        }

        private void fileChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                fileInfo(filePath, ref plainText, ref bitsCount);
                input = BitArrayToStr(plainText);
                fileInput.Text = input;
            }
        }

        void fileInfo(string filePath,ref BitArray plainText, ref int fileSizeInBits)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            plainText = new BitArray(fileBytes);
            ReverseBits(plainText);
            
    
            //  cipherText = new BitArray(fileBytes);
            int fileSizeInBytes = plainText.Length;
            fileSizeInBits = fileSizeInBytes * 8;
        }
        static void ReverseBits(BitArray bitArray)
        {
            int length = bitArray.Length;
            bool[] reversed = new bool[length];

            for (int byteStart = 0; byteStart < length; byteStart += 8)
            {
                for (int i = 0; i < 8 && byteStart + i < length; i++)
                {
                    reversed[byteStart + i] = bitArray[byteStart + (7 - i)];
                }
            }

            for (int i = 0; i < length; i++)
            {
                bitArray[i] = reversed[i];
            }
        }

        BitArray ConvertFromString(string str)
        {
            BitArray regState = new BitArray(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                regState[i] = str[i] == '1'; // Если символ '1', то бит = true; иначе = false
            }
            return regState;
        }

        byte[] ConvertFromBits(BitArray bitArray)
        {
            ReverseBits(bitArray);
            byte[] restoredBytes = new byte[bitArray.Length / 8]; // Вычисление количества байтов

            bitArray.CopyTo(restoredBytes, 0); // Копируем содержимое BitArray в массив байтов
            return restoredBytes;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                byte[] restoredBytes = ConvertFromBits(cipherText);
                // Запись массива байтов в выбранный файл
                File.WriteAllBytes(savePath, restoredBytes);

                MessageBox.Show($"Файл успешно сохранён:\n{savePath}",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        string BitArrayToStr(BitArray array)
        {
            StringBuilder temp = new StringBuilder();
            if (array.Length <= 240)
            {
                foreach (bool bit in array)
                {
                    temp.Append(bit ? 1 : 0);
                }
            }
            else
            {
                temp.Append("Первые 15 байт: \n");
                for (int i = 0; i < 120; i++)
                    temp.Append(array[i] ? 1 : 0);
                temp.Append($"{Environment.NewLine}Последние 15 байт: \n");
                for (int i = 120; i > 0; i--)
                {
                    temp.Append(array[array.Length - i] ? 1 : 0);
                }
            }

            return temp.ToString();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            keyInput.Text = string.Empty;
            fileInput.Text = string.Empty;
            output.Text = string.Empty;
            plainText = new BitArray(0);
            cipherText = new BitArray(0);
           // registerState = null;
        }

        private void regInput_TextChanged(object sender, EventArgs e)
        {
            lengthCount.Text = $@"Длина введенных состояний: {regInput.Text.Count(x => x == '0' || x == '1')}";
        }

    }

}

    

