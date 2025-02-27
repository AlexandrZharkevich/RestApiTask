﻿using System;
using System.Linq;

namespace RestApiTask.Utils
{
    class RandomStringGenerator
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
