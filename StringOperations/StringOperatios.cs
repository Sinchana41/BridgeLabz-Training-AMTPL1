using System;

namespace StringMethods
{
    class StringOperations
    {
        public static void Main()
        {
            string S = "Seetha";
            Console.WriteLine(S);//Seetha
            S = S + " Ram ";
            Console.WriteLine(S);//Seetha Ram
            Console.WriteLine(S.Substring(0, 3));//See
            Console.WriteLine(S.Replace("ee", "i"));//Sitha Ram
            Console.WriteLine(S.Contains("R"));//True
            Console.WriteLine(S.StartsWith("S"));//True
            Console.WriteLine(S.ToUpper());//SEETHA RAM
            Console.WriteLine(S.ToLower());//seetha ram
            Console.WriteLine(String.IsNullOrEmpty(S));//False
            Console.WriteLine(String.IsNullOrWhiteSpace(S));//False
            string[] Arr = S.Split("a");
            foreach (string str in Arr)
            {
                Console.Write(str+" ");//Seeth  R m
            }
        }
    }
}