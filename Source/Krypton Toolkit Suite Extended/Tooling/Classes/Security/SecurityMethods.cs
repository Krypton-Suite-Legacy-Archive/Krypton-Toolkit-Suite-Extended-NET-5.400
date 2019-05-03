﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Core.Classes.Security
{
    public class SecurityMethods
    {
        /// <summary>
        /// Creates the password. Code from: https://stackoverflow.com/questions/54991/generating-random-passwords
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();


            RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();

            Random random = new Random();

            while (0 < length--)
            {
                res.Append(valid[random.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}