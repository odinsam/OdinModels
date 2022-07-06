using System;
using System.IO;
using System.Security.Cryptography;

namespace OdinModels.OdinUtils.OdinSecurity.OdinStreamSecurity.StreamSecurityExtensions
{
    public static class StreamSecurity
    {
        /// <summary>
        /// stream sha256 加密
        /// </summary>
        /// <param name="stream">需要加密的流</param>
        /// <returns>sha256加密后的string信息</returns>
        public static string Sha256(this Stream stream)
        {
            using var sha256 = SHA256.Create();
            var by = sha256.ComputeHash(stream);
            var result = BitConverter.ToString(by).Replace("-", "").ToLower(); //64
            return result;
        }
    }
}