using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class MyCookieCollection
    {
        private Dictionary<string, string> cookies = new Dictionary<string, string>();
        public string this[string name]
        {
            get
            {
                if (cookies.ContainsKey(name))
                    return cookies[name];
                return null;
            }
            set
            {
                cookies[name] = value;
            }


        }



        public void PRintAllCookies()
        {
            foreach (var cookie in cookies)
            {
                Console.WriteLine($"{cookie.Key}: {cookie.Value}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {



            MyCookieCollection cookies = new MyCookieCollection();
            cookies["username"] = "hana";
            cookies["theme"] = "dark";


            Console.WriteLine($"Username: {cookies["username"]}");
            Console.WriteLine($"Theme: {cookies["theme"]}");    
            Console.WriteLine($"Language: {cookies["language"]??"not set"}");
            cookies.PRintAllCookies();

        }
    }
}