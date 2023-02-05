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
                int x;
                int tmp = text[i];
                
                if (tmp >= 32 && tmp <= 126)
                {
                    x = (tmp + key[j] - 64) % 95;
                    if (x < 0)
                        x += 95;
                    encryptedText += (char)(x + 32);
                    j++;
                }

                else
                    encryptedText += (char)tmp;


            }
            return encryptedText;
        }

        public String Decrypt(String text, String key)
        {

            string decryptedText = "";
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int x;

                int tmp = text[i];
                if (tmp >= 32 && tmp <= 126)
                {
                    x = (tmp - key[j] + 95) % 95;
                    if (x < 0)
                        x += 95;
                    decryptedText += (char)(x + 32);
                    j++;
                }

                else
                    decryptedText += (char)tmp;

            }
            return decryptedText;

        }

    }
}
