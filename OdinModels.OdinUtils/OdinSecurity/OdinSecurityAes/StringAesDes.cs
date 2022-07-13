using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using OdinModels.OdinUtils.OdinExceptionExtensions;
using OdinModels.OdinUtils.OdinExtensions;

namespace OdinModels.OdinUtils.OdinSecurity.OdinSecurityAes
{
    public class StringAesDes
    {
        /// <summary>  
        /// AES加密算法  
        /// </summary>  
        /// <param name="input">明文字符串</param>  
        /// <param name="key">密钥（32位）</param>  
        /// <param name="aesAi">加密偏移量</param>  
        /// <returns>字符串</returns>  
        public static string EncryptByAes(string input, string key = null, string aesAi = null)
        {
            byte[] keyBytes = null;
            byte[] aiBytes = null;
            if (!key.IsNullOrEmpty() && key.Length != 32)
                throw new OdinException(EnumOdinException.EncryptByAesX01);
            if (!aesAi.IsNullOrEmpty() && key.IsNullOrEmpty())
                throw new OdinException(EnumOdinException.EncryptByAesX02);
            if (aesAi != null && !aesAi.IsNormalized() && aesAi.Length != 16)
                throw new OdinException(EnumOdinException.EncryptByAesX03);
            if (!key.IsNullOrEmpty())
                keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 32));
            if (!aesAi.IsNullOrEmpty())
                aiBytes = Encoding.UTF8.GetBytes(aesAi.Substring(0, 16));
            using var aesAlg = Aes.Create();
            if (keyBytes != null)
                aesAlg.Key = keyBytes;
            if (aiBytes != null)
                aesAlg.IV = aiBytes;
            ICryptoTransform encryptor = null;
            if (key.IsNullOrEmpty())
                encryptor = aesAlg.CreateEncryptor();
            else
                encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using MemoryStream msEncrypt = new MemoryStream();
            using CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            using StreamWriter swEncrypt = new StreamWriter(csEncrypt);
            swEncrypt.Write(input);
            byte[] bytes = msEncrypt.ToArray();
            return bytes.ConvertByteArrayToHexString();
        }

        /// <summary>  
        /// AES解密  
        /// </summary>  
        /// <param name="input">密文字节数组</param>  
        /// <param name="key">密钥（32位）</param>  
        /// <param name="aesAi">加密偏移量</param>  
        /// <returns>返回解密后的字符串</returns>  
        public static string DecryptByAes(string input, string key = null, string aesAi = null)
        {
            byte[] keyBytes = null;
            byte[] aiBytes = null;
            if (!key.IsNullOrEmpty() && key.Length != 32)
                throw new OdinException(EnumOdinException.DecryptByAesX01);
            if (!aesAi.IsNullOrEmpty() && key.IsNullOrEmpty())
                throw new OdinException(EnumOdinException.DecryptByAesX02);
            if (aesAi != null && !aesAi.IsNormalized() && aesAi.Length != 16)
                throw new OdinException(EnumOdinException.DecryptByAesX03);
            if (!key.IsNullOrEmpty())
                keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 32));
            if (!aesAi.IsNullOrEmpty())
                aiBytes = Encoding.UTF8.GetBytes(aesAi.Substring(0, 16));
            byte[] inputBytes = input.ConvertHexStringToByteArray();
            using var aesAlg = Aes.Create();
            if (keyBytes != null)
                aesAlg.Key = keyBytes;
            if (aiBytes != null)
                aesAlg.IV = aiBytes;
            ICryptoTransform decryptor = null;
            if (key.IsNullOrEmpty())
                decryptor = aesAlg.CreateDecryptor();
            else
                decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream(inputBytes))
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srEncrypt = new StreamReader(csEncrypt))
                    {
                        return srEncrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}