using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server2
{
    public class Program
    {
        public static List<User> users = new List<User>();
        public static IPAddress IpAddress;
        public static int Port;
        static void Main(string[] args)
        {
        }
        public static bool AutoRiazationUser(string login, string password)
        {
            User user= null;
            user= users.Find(x=>x.login == login && x.password==password);
            return user != null;
        }
        public static List<string> GetDirectory(string src)
        {
            List<string> FolderFiles = new List<string>();
            if(Directory.Exists(src))
            {
                string[] dirs = Directory.GetDirectories(src);
                foreach (string dir in dirs)
                {
                    string NameDirectory = dir.Replace(src, "");
                    FolderFiles.Add(NameDirectory + "/");
                }
                string[] files = Directory.GetFiles(src);
                foreach (string file in files)
                {
                    string NameFile = file.Replace(src, "");
                    FolderFiles.Add(NameFile);

                }
            }
            return FolderFiles;
        }
    }
}
