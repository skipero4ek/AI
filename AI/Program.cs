using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            while (!(str = Console.ReadLine()).Equals("Пока"))
            {
                str = str.ToLower();
                
                if (str.IndexOf("div")!=-1 || str.IndexOf("раз")!=-1 || str.IndexOf("умн")!=-1 || str.IndexOf("mul")!=-1 || str.IndexOf("sum")!=-1 || str.IndexOf("сум")!=-1 || str.IndexOf("sub")!=-1 || str.IndexOf("отн")!=-1)
                {
                    MathTask(str);
                }
                else
                {
                    if (str.IndexOf("hello") != -1 || str.IndexOf("привет") != -1 || str.IndexOf("hi") != -1 || str.IndexOf("здор") != -1 || str.IndexOf("здра") != -1 || str.IndexOf("добрый ") != -1 || str.IndexOf("good m") != -1 || str.IndexOf("good e") != -1 || str.IndexOf("good d") != -1)
                    {
                        Console.WriteLine(Hello.Result());                            
                    }
                    if (str.IndexOf("whats") != -1 || str.IndexOf("how") != -1 || str.IndexOf("как") != -1)
                    {
                        Console.WriteLine(HowAreYou.Result("how"));
                    }
                    if (str.IndexOf("drink") != -1|| str.IndexOf("пить") != -1 || str.IndexOf("пьем") != -1)
                    {
                        Console.WriteLine(HowAreYou.Result("drink"));
                    }
                    if (str.IndexOf("plan") != -1)
                    {
                        Console.WriteLine(HowAreYou.Result("plans"));
                    }

                }
                
            }
            Console.ReadKey();
        }
        public static void MathTask(string str)
        {
            string result = "";
            if (str.Length > 2)
            {
                string s = new String(new char[] { str[0], str[1], str[2] });
                
                int first = 0;
                int second = 0;
                for (int i = s.Length; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        for (int j = i + 1; j < str.Length; j++)
                        {
                            if (str[j] != ' ')
                            {
                                try
                                {
                                    first = first * 10 + (int)char.GetNumericValue(str[j]);
                                }
                                catch
                                {
                                    result += Task.Result();
                                    break;
                                }
                            }
                            else
                            {
                                for (int k = j + 1; k < str.Length; k++)
                                {
                                    try
                                    {
                                        second = second * 10 + (int)char.GetNumericValue(str[k]);
                                    }
                                    catch
                                    {
                                        result += Task.Result();
                                        break;
                                    }
                                }
                                if (!result.Equals(Task.Result()))
                                {
                                    if ((s.Equals("div") || s.Equals("раз")||s.Equals("под")) && second != 0)
                                    {
                                        result += Task.Result("div");
                                        result += first / second;
                                    }
                                    else if (s.Equals("умн") || s.Equals("mul")||s.Equals("пом"))
                                    {
                                        result += Task.Result("mul");
                                        result += first * second;
                                    }
                                    else if (s.Equals("sum") || s.Equals("сум")||s.Equals("при"))
                                    {
                                        result += Task.Result("sum");
                                        result += first + second;
                                    }
                                    else if (s.Equals("sub") || s.Equals("отн")||s.Equals("мин"))
                                    {
                                        result += Task.Result("sub");
                                        result += first + second;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }

                }
                
            }

            if(result.Length == 0)
            {
                Console.WriteLine(Task.Result());
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
    
}
