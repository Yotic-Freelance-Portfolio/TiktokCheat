using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1tokBD
{
    internal class Config
    {
        internal static string urlTikTok = @"https://www.tiktok.com/@hahahaebaltvoimam";
        internal static string dataBase = @"C:\\BaseGood.txt";
        internal static uint threads = 1;
        internal static bool subscriptions = true;
        internal static bool likes = true;
        internal static bool comments = true;
        internal static bool views = false;
        internal static string cookie = "qios6rhg2ava3dhsir08mmiq75";
        internal static bool headless = false;

        internal static void Save()
        {
            if (!File.Exists(@"C:\\DooD Corporation\1tokBD\Config.cfg"))
                File.Delete(@"C:\\DooD Corporation\1tokBD\Config.cfg");

            using (StreamWriter sw = new StreamWriter(@"C:\\DooD Corporation\1tokBD\Config.cfg", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(urlTikTok + "|" + dataBase + "|" + threads + "|" + subscriptions + "|" + likes + "|" + comments + "|" + views + "|" + cookie + "|" + headless);
            }
        }

        internal static void Get()
        {
            if (File.Exists(@"C:\\DooD Corporation\1tokBD\Config.cfg"))
                using (StreamReader sr = new StreamReader(@"C:\\DooD Corporation\1tokBD\Config.cfg", Encoding.Default))
                {
                    string[] lines = sr.ReadToEnd().Split('|');
                    urlTikTok = lines[0];
                    dataBase = lines[1];
                    threads = uint.Parse(lines[2]);
                    subscriptions = Convert.ToBoolean(lines[3]);
                    likes = Convert.ToBoolean(lines[4]);
                    comments = Convert.ToBoolean(lines[5]);
                    views = Convert.ToBoolean(lines[6]);
                    cookie = lines[7];
                    headless = Convert.ToBoolean(lines[8]);
                }
        }
            
    }
}
