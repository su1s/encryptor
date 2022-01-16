using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Encryptor
{
    public class Functions
    {
        // XOR Bytes
        public static byte[] xor (byte[] data , byte[] key)
        {
            byte[] encoded = new byte[data.Length];
            int key_length = key.Length;
            int key_counter = 0;
            for (int i = 0; i < encoded.Length; i++)
            {
                encoded[i] = (byte)(data[i] ^ key[key_counter]);
                key_counter++; 
                if (key_counter == key_length)
                {
                    key_counter = 0;
                }
            }
            return encoded;
        }
        // Insertion Encode
        public static byte[] EncodeInsertion (byte[] data, byte[] InsertBytes, int Frequency)
        {
            byte[] encoded = new byte[0];
            int key_counter = 0;
            int Total_counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                // Add Byte 
                Array.Resize(ref encoded, Total_counter + 1);
                encoded[Total_counter] = data[i];
                // Inc Counter 
                Total_counter++;
                if ((i+1)  % Frequency == 0)  // Insert Byte
                {
                    Array.Resize(ref encoded, Total_counter + 1);
                    encoded[Total_counter] = InsertBytes[key_counter];
                    Total_counter++;
                    key_counter++;
                    if (key_counter == InsertBytes.Length)
                    {
                        key_counter = 0;
                    }
                }
            }
            return encoded;
        }
        // Insertion Decode
        public static byte[] DecodeInsertion(byte[] data, int Frequency)
        {
            byte[] encoded = new byte[0];
            int Total_counter = 0;
            for (int i = 0; i < data.Length; i++)
            {

                if ((i+1) % (Frequency + 1) == 0)  // its an inserted byte
                {
                    // Do Nothing 
                }
                else
                {
                    // Append the Byte
                    Array.Resize(ref encoded, Total_counter + 1);
                    encoded[Total_counter] = data[i];
                    Total_counter++;
                }
            }
            return encoded;
        }
        // Caeser Encode Bytes
        public static byte[] EncodeCeaser(byte[] data, int step)
        {
            byte[] encoded = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                encoded[i] = (byte)(((int)data[i] + step));
            }
            return encoded;
        }
        // Caeser Decode Bytes
        public static byte[] DecodeCeaser(byte[] data, int step)
        {
            byte[] encoded = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                encoded[i] = (byte)(((int)data[i] - step));
            }
            return encoded;
        }
        // XANAX encode
        public static byte[] EncodeXanax(byte[] data, byte XOR1,int add1, int add2, byte XOR2)
        {
            byte[] encoded = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                // XOR
                encoded[i] = (byte)(data[i] ^ XOR1);
                // Add 
                encoded[i] = (byte)(((int)encoded[i] + add1));
                // NOT
                encoded[i] = (byte)(~encoded[i])  ;
                // Add 
                encoded[i] = (byte)(((int)encoded[i] + add2));
                // XOR
                encoded[i] = (byte)(encoded[i] ^ XOR2);
            }
            return encoded;
        }
        // XANAX dncode
        public static byte[] DecodeXanax(byte[] data, byte XOR1, int add1, int add2, byte XOR2)
        {
            byte[] encoded = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                // XOR
                encoded[i] = (byte)(data[i] ^ XOR2);
                // Sub
                encoded[i] = (byte)(((int)encoded[i] - add2));
                // NOT
                encoded[i] = (byte)~encoded[i] ;
                // Sub  
                encoded[i] = (byte)(((int)encoded[i] - add1));
                // XOR
                encoded[i] = (byte)(encoded[i] ^ XOR1);
            }
            return encoded;
        }
        // Encrypt AES
        public static byte[] EncryptAES(byte[] plain, byte[] Key, byte[] IV)
        {
            byte[] encrypted; ;
            using (MemoryStream mstream = new MemoryStream())
            {
                using (AesCryptoServiceProvider aesProvider = new AesCryptoServiceProvider())
                {
                    aesProvider.Padding = PaddingMode.PKCS7;
                    aesProvider.Mode = CipherMode.CBC;

                    using (CryptoStream cryptoStream = new CryptoStream(mstream,
                        aesProvider.CreateEncryptor(Key, IV), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plain, 0, plain.Length);
                    }
                    encrypted = mstream.ToArray();
                }
            }
            return encrypted;
        }
        // Decrypt AES 
        public static byte[] DecryptAES(byte[] encrypted, byte[] Key, byte[] IV)
        {
            {
                byte[] plain;
                int count;
                using (MemoryStream mStream = new MemoryStream(encrypted))
                {
                    using (AesCryptoServiceProvider aesProvider = new AesCryptoServiceProvider())
                    {
                        aesProvider.Padding = PaddingMode.PKCS7;
                        aesProvider.Mode = CipherMode.CBC;
                       
                        using (CryptoStream cryptoStream = new CryptoStream(mStream,
                         aesProvider.CreateDecryptor(Key, IV), CryptoStreamMode.Read))
                        {
                            plain = new byte[encrypted.Length];
                            count = cryptoStream.Read(plain, 0, plain.Length);
                        }
                    }
                }
                byte[] returnval = new byte[count];
                Array.Copy(plain, returnval, count);
                return returnval;
            }
        }
    }
}
