using System;
using System.Collections.Generic;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var list  = new List<int>(){
                1,2,3
            };
            var dic = new Dictionary<int, string>(){
                [1] =  "Miguel",
                [2] =  "Haana",
                [3] =  "Rafael"
            };
            foreach(var i in list){
                Console.WriteLine(dic[i]);
            }
        
        }
    }
}
