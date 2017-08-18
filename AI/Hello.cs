using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._08._2017CW
{
    class Hello
    {
        public static string Result()
        {
            return "Привет";
        }
        public static string Result(string data)
        {
            string[] Items = File.ReadAllLines("hello.txt");

            return "";
        }

    }
}
