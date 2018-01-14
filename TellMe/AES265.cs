using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace TellMe
{
    class AES265
    {
        private Byte[] bKey;
        private Byte[] bVector;

        // Thees strings will be used to replace EQUAL mark
        private static String[] MIXER = {"\"", "!", "@", "#", "$", "%", "^", "[", "]", "{", "}", "(", ")", "*", "~"};
        private static int MIXER_LEN = MIXER.Length;

        // Each line size
        private static int LINE_SIZE = 10;

        // For random
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        public AES265(String key)
        {
            // Create Key
            this.bKey = new Byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(this.bKey.Length)), this.bKey, this.bKey.Length);

            // Create Vector
            String tmpVector = key.Substring(0, 3);
            char[] keyArray = key.ToCharArray();
            Array.Sort(keyArray);
            tmpVector += new String(keyArray);
            // Invite Date time to make sure the message can only be read in the same day
            tmpVector += System.DateTime.Now.ToString("MM/dd_yyyy");

            this.bVector = new Byte[16];
            Array.Copy(Encoding.UTF8.GetBytes(tmpVector.PadRight(this.bVector.Length)), this.bVector, this.bVector.Length);
        }

        /// <summary>
        /// Encrypt
        /// </summary>
        /// <param name="inStr">Original data</param>
        /// <returns>Encrypted data</returns>
        public String Encrypt(String inStr)
        {
            return formatEncryptedString(this.AESEncrypt(inStr, this.bKey, this.bVector));
        }

        /// <summary>
        /// Decrypt
        /// </summary>
        /// <param name="inStr">Encrypted data</param>
        /// <returns>Original data</returns>
        public String Decrypt(String inStr)
        {
            return this.AESDecrypt(cleanFormat(inStr), this.bKey, this.bVector);
        }

        /// <summary>
        /// AESEncrypt
        /// </summary>
        /// <param name="inStr">Original data</param>
        /// <param name="bKey">key</param>
        /// <param name="bVector">vector</param>
        /// <returns>Encrypted data</returns>
        private String AESEncrypt(String inStr, Byte[] bKey, Byte[] bVector)
        {
            Byte[] Cryptograph = null;

            try
            {
                Byte[] plainBytes = Encoding.UTF8.GetBytes(inStr);

                Rijndael Aes = Rijndael.Create();

                using (MemoryStream Memory = new MemoryStream())
                {
                    using (
                        CryptoStream Encryptor = new CryptoStream(
                                Memory,
                                Aes.CreateEncryptor(bKey, bVector),
                                CryptoStreamMode.Write
                            )
                        )
                    {
                        Encryptor.Write(plainBytes, 0, plainBytes.Length);
                        Encryptor.FlushFinalBlock();

                        Cryptograph = Memory.ToArray();
                    }
                }
            }
            catch
            {
                Cryptograph = null;
            }

            return (null == Cryptograph)? "" : Convert.ToBase64String(Cryptograph);
        }

        /// <summary>
        /// AESDecrypt
        /// </summary>
        /// <param name="inStr">Encrypted data</param>
        /// <param name="bKey">key</param>
        /// <param name="bVector">vector</param>
        /// <returns>Original data</returns>
        private String AESDecrypt(String inStr, Byte[] bKey, Byte[] bVector)
        {
            Byte[] original = null;

            try
            {
                Byte[] encryptedBytes = Convert.FromBase64String(inStr);

                Rijndael Aes = Rijndael.Create();

                using (MemoryStream Memory = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream Decryptor = new CryptoStream(Memory,
                    Aes.CreateDecryptor(bKey, bVector),
                    CryptoStreamMode.Read))
                    {
                        using (MemoryStream originalMemory = new MemoryStream())
                        {
                            Byte[] Buffer = new Byte[1024];
                            Int32 readBytes = 0;
                            while ((readBytes = Decryptor.Read(Buffer, 0, Buffer.Length)) > 0)
                            {
                                originalMemory.Write(Buffer, 0, readBytes);
                            }

                            original = originalMemory.ToArray();
                        }
                    }
                }
            }
            catch
            {
                original = null;
            }
            return (null == original)? "" : Encoding.UTF8.GetString(original);
        }

        /// <summary>
        /// Format encrypted string
        /// </summary>
        /// <param name="inPara">encrypted string</param>
        /// <returns>Formated value</returns>
        private String formatEncryptedString(String inPara)
        {
            String RTN = inPara;
            // Check string
            if (inPara.Contains("="))
            {
                int startIndex = inPara.IndexOf("=");
                int lengthRequired = inPara.Length - startIndex;
                RTN = inPara.Substring(0, startIndex);
                RTN += getRandomStrings(lengthRequired);
            }

            String _wrk = RTN;
            RTN = "";
            while (true)
            {
                if (_wrk.Length > LINE_SIZE)
                {
                    RTN += _wrk.Substring(0, LINE_SIZE) + Environment.NewLine;
                    _wrk = _wrk.Substring(LINE_SIZE);
                }
                else
                {
                    RTN += _wrk;
                    break;
                }
            }

            return RTN;
        }

        /// <summary>
        /// Random String Generator
        /// </summary>
        /// <param name="length">String length</param>
        /// <returns>Random String</returns>
        private String getRandomStrings(int length)
        {
            String RTN = "";
            for (int i = 0; i < length; i++)
            {
                byte[] rno = new byte[2];
                rngCsp.GetBytes(rno);
                int randomvalue = BitConverter.ToUInt16(rno, 0);
                RTN += MIXER[randomvalue % MIXER_LEN];
            }
            return RTN;
        }

        /// <summary>
        /// Clean all formated value
        /// </summary>
        /// <param name="inPara">Formated value</param>
        /// <returns>Style free value</returns>
        private String cleanFormat(String inPara)
        {
            String RTN = inPara;
            for (int i = 0; i < MIXER_LEN; i++)
            {
                if (RTN.Contains(MIXER[i]))
                {
                    RTN = RTN.Replace(MIXER[i], "=");
                }
            }

            if(RTN.Contains(Environment.NewLine))
            {
                RTN = RTN.Replace(Environment.NewLine, "");
            }
            return RTN;
        }
    }
}
