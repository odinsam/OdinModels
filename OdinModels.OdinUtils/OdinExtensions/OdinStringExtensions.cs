using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OdinModels.OdinUtils.OdinExtensions
{
    public static class OdinStringExtensions
    {

        /// <summary>
        /// Indicates whether the specified string is null or an empty string ("").
        /// </summary>
        /// <param name="str">The string to test</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
        /// <summary>  
        /// Unicode字符串转为正常字符串  
        /// </summary>  
        /// <param name="srcText"></param>  
        /// <returns></returns>  
        public static string UnicodeToString(this string srcText)
        {
            return Regex.Unescape(srcText);
        }

        /// <summary>
        /// string to ascii
        /// </summary>
        /// <param name="str">string</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns>ascii code</returns>
        public static string ToAscii(this string str)
        {
            byte[] array = System.Text.Encoding.ASCII.GetBytes(str);
            string asciiStr2 = null;
            if (asciiStr2 == null) throw new ArgumentNullException(nameof(asciiStr2));
            foreach (var t in array)
            {
                int asciicode = (int)(t);
                asciiStr2 += Convert.ToString(asciicode);
            }
            return asciiStr2;
        }


        /// <summary>
        /// StringToBase64String
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>Base64String</returns>
        public static string StringToBase64String(this string str)
        {
            byte[] bt = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(bt);
        }

        /// <summary>
        /// Base64StringToString
        /// </summary>
        /// <param name="str">Base64String</param>
        /// <returns>String</returns>
        public static string Base64StringToString(this string str)
        {
            byte[] bt = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(bt);
        }

        /// <summary>
        /// 格式化json字符串
        /// </summary>
        /// <param name="str">json string</param>
        /// <returns>json format string</returns>
        public static string ToJsonFormatString(this string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Newtonsoft.Json.Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }

        private static XmlDocument GetXmlDocument(string xmlString)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            return document;
        }

        private static string ConvertXmlDocumentTostring(XmlDocument xmlDocument)
        {
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memoryStream, null)
            {
                Formatting = System.Xml.Formatting.Indented //缩进
            };
            xmlDocument.Save(writer);
            StreamReader streamReader = new StreamReader(memoryStream);
            memoryStream.Position = 0;
            string xmlString = streamReader.ReadToEnd();
            streamReader.Close();
            memoryStream.Close();
            return xmlString;
        }

        /// <summary>
        /// to xml string
        /// </summary>
        /// <param name="xmLString">xml string</param>
        /// <returns>xml format string</returns>
        public static string ToXmlFormatString(this string xmLString)
        {
            XmlDocument xmlDocument = GetXmlDocument(xmLString);
            return ConvertXmlDocumentTostring(xmlDocument);
        }

        /// <summary>
        /// string转16进制
        /// </summary>
        /// <param name="strAscii">string to ascii</param>
        /// <param name="separator">分隔符</param>
        /// <returns>16进制的string</returns>
        public static string ConvertStringToHex(this string strAscii, string separator = null)
        {
            StringBuilder sbHex = new StringBuilder();
            foreach (char chr in strAscii)
            {
                sbHex.Append(String.Format("{0:X2}", Convert.ToInt32(chr)));
                sbHex.Append(separator ?? string.Empty);
            }
            return sbHex.ToString();
        }

        /// <summary>
        /// 16进制转string
        /// </summary>
        /// <param name="hexValue">16进制string</param>
        /// <param name="separator">分隔符</param>
        /// <returns>string说</returns>
        public static string ConvertHexToString(this string hexValue, string separator = null)
        {
            hexValue = string.IsNullOrEmpty(separator) ? hexValue : hexValue.Replace(string.Empty, separator);
            StringBuilder sbStrValue = new StringBuilder();
            while (hexValue.Length > 0)
            {
                sbStrValue.Append(Convert.ToChar(Convert.ToUInt32(hexValue.Substring(0, 2), 16)).ToString());
                hexValue = hexValue.Substring(2);
            }
            return sbStrValue.ToString();
        }
        
        /// <summary>
        /// 将指定的16进制字符串转换为byte数组
        /// </summary>
        /// <param name="s">16进制字符串(如：“7F 2C 4A”或“7F2C4A”都可以)</param>
        /// <returns>16进制字符串对应的byte数组</returns>
        public static byte[] ConvertHexStringToByteArray(this string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary>
        /// string to bytes
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>byte array</returns>
        public static byte[] ConvertStringToBytes(this string str)
        {
            return System.Text.Encoding.Default.GetBytes(str);
        }

        /// <summary>
        /// Utf8ToGb2312
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>Gb2312 string</returns>
        public static string Utf8ToGb2312(this string text)
        {
            //声明字符集   
            //utf8   
            var utf8 = System.Text.Encoding.GetEncoding("utf-8");
            //gb2312   
            var gb2312 = System.Text.Encoding.GetEncoding("gb2312");
            byte[] utf;
            utf = utf8.GetBytes(text);
            utf = System.Text.Encoding.Convert(utf8, gb2312, utf);
            //返回转换后的字符   
            return gb2312.GetString(utf);
        }

        /// <summary>
        /// StringEncode
        /// </summary>
        /// <param name="text">string</param>
        /// <param name="sourceEncode">source encode</param>
        /// <param name="transEncode">trans Encode</param>
        /// <returns>string</returns>
        public static string ConvertStringEncode(this string text, Encoding sourceEncode, Encoding transEncode)
        {
            var utf = sourceEncode.GetBytes(text);
            utf = Encoding.Convert(sourceEncode, transEncode, utf);
            //返回转换后的字符   
            return transEncode.GetString(utf);
        }
    
        /// <summary>
        /// string to Enum
        /// </summary>
        /// <param name="text"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ConvertStringToEnum<T>(this string text)
        {
            return (T)Enum.Parse(typeof(T), text);
        }
        
        /// <summary>
        /// QueryStringToJson
        /// </summary>
        /// <param name="queryString">http request queryString</param>
        /// <returns>json string</returns>
        public static string QueryStringToJson(this string queryString)
        {
            List<string> strlst = queryString.Split('&').ToList();
            JObject jsonObject = new JObject();
            foreach (var item in strlst)
            {
                string key = item.Split('=')[0];
                string value = item.Split('=')[1];
                jsonObject.Add(key, value);
            }
            return jsonObject.ToString();

        }
        
        /// <summary>
        /// ConvertStringToDateTime
        /// </summary>
        /// <param name="dateTimeStr">dateTimeStr</param>
        /// <param name="dateTimeFormat">dateTimeFormat</param>
        /// <returns>DateTime</returns>
        public static DateTime ConvertStringToDateTime(this string dateTimeStr, string dateTimeFormat)
        {
            DateTime dt = DateTime.ParseExact(dateTimeStr, dateTimeFormat, System.Globalization.CultureInfo.CurrentCulture);
            return dt;
        }


    }
}