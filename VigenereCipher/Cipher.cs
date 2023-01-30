using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    internal class Cipher
    {
       
        public String ConvertKey(String text, String key)
        {
            int x = text.Length;

            for (int i = 0; ;i++)
            {
                if(x == i)
                    i = 0;
                
                if(key.Length == text.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }

        public String Encrypt(String text, String key)
        {
            string encryptedText = "";
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {

 

                int x = (text[i] + key[j]) % 127;
                if (x < 32)
                {
                    x += 32;
                }
                encryptedText += (char)x;
                j = (j + 1) % key.Length;
            }
            return encryptedText;
        }

        public String Decrypt(String text, String key)
        {

            string decryptedText = "";
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {

                int x = (text[i] - key[j] + 127) % 127;
                int y = (text[i] + key[j]) % 127;
                if(y < 32)
                {
                    x += 32;
                }
                if(x < 32)
                {
                    x += 95;
                }
                

                decryptedText += (char)x;
                j = (j + 1) % key.Length;
            }
            return decryptedText;
            


        }

    }
}
