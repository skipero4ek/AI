using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AI
{
    class Task
    {
        public static string Result()
        {
            return "Result:";
        }

        public static string Result(string data)
        {
            string[] items = File.ReadAllLines("Task.txt",Encoding.UTF8);
            List<string> good = new List<string>();
            foreach(var temp in items)
            {
                if(temp.IndexOf(data)!=-1) // проверяем наличие элемента 
                {
                    good.Add(temp);
                }
            }
           


           Random r = new Random();
           string s = good[r.Next(0,good.Count)];
           string[] res = s.Split(':');
           return res[1];

        }
    }
}
