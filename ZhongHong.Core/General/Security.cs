﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ZhongHong.Core.General
{
    public class Security
    {
        /// <summary>
        /// 256位散列加密
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public static string SHA256(string plainText)
        {
            SHA256Managed _sha256 = new SHA256Managed();
            byte[] _cipherText = _sha256.ComputeHash(Encoding.Default.GetBytes(plainText));
            return Convert.ToBase64String(_cipherText);
        }
    }
}