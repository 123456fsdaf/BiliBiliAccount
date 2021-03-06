using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilibiliAPI.ApiTools
{
    public static class Current
    {
        public static string LocalID { get; private set; }
        private static object HasInit { get; set; } = false;
        public static Random Radom { get; private set; }
        public static MyHttpClient HttpClient { get; private set; }
        public static void Init()
        {
            if (HasInit is bool value && value == false)
            {
                HasInit = true;
                Radom = new Random();
                HttpClient = new MyHttpClient();
                LocalID = Guid.NewGuid().ToString();
            }
        }
    }
}
