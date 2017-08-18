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
                if (str.Length > 2)
                {
                    string s = new String(new char[] { str[0], str[1], str[2] });
                    if (s.Equals("div") || s.Equals("раз") || s.Equals("умн") || s.Equals("mul") || s.Equals("sum") || s.Equals("сум") || s.Equals("sub") || s.Equals("отн"))
                    {
                        MathTask(str);
                    }
                    else
                    {
                        if (str.IndexOf("Hello") != -1 || str.IndexOf("Привет") != -1 || str.IndexOf("Hi") != -1 || str.IndexOf("Здор") != -1 || str.IndexOf("Здра") != -1 || str.IndexOf("Добрый ") != -1 || str.IndexOf("Good m") != -1 || str.IndexOf("Good e") != -1 || str.IndexOf("Good d") != -1)
                        {
                            Console.WriteLine(Hello.Result());                            
                        }
                        if (str.IndexOf("Whats") != -1 || str.IndexOf("How") != -1)
                        {
                            Console.WriteLine(HowAreYou.Result("how"));
                        }
                        if (str.IndexOf("Drink") != -1 || str.IndexOf("drink") != -1)
                        {
                            Console.WriteLine(HowAreYou.Result("drink"));
                        }
                        if (str.IndexOf("plan") != -1)
                        {
                            Console.WriteLine(HowAreYou.Result("plans"));
                        }

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
