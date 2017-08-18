using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace AI
{
     class HowAreYou
    {
        HowAreYou() { }

        public static string Result()
        { 
        return Result("how");
        }
        public static string Result(String str)
        {
            Random r = new Random();
            string[]sArr= File.ReadAllLines("Answer.txt");
            List<string> ls = new List<string>();
                foreach(string x in sArr)
                {
                    if(x.IndexOf(str)!=-1)
                    {
                        ls.Add(x);
                    }
                }
            int index = r.Next(ls.Count);
            string res=ls[index].ToString();
            return res;
        }

    }
}
