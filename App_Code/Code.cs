using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace YingDingWebApp
{
    public enum StatusCode
    {
        Ok = 200,
        NotFound = 404,
        Frozen = 403,
        Error = 500
    }
    public class ReturnMsg
    {
        /// <summary>
        /// 状态码,主要用得到对应的信息,以后通过这个内容进行判断 操作是否完成 
        /// </summary>
        public StatusCode Code { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

    }

    public static class MD5Helper
    {
        public static string Md5(string value)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(value)) return result;
            using (var md5 = MD5.Create())
            {
                result = GetMd5Hash(md5, value);
            }
            return result;
        }
        static string GetMd5Hash(MD5 md5Hash,string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            foreach (byte t in data)
            {
                sBuilder.Append(t.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        static bool VerifyMd5Hash(MD5 md5Hash,string input,string hash)
        {
            var hashOfInput = GetMd5Hash(md5Hash,input);
            var comparer = StringComparer.OrdinalIgnoreCase;
            return 0 == comparer.Compare(hashOfInput, hash);
        }
    }
}