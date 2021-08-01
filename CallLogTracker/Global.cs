using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker
{
    public class Global
    {
        private static Global instance = null;
        private static object padlock = new object();

        public static Global Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                        instance = new Global();
                    return instance;
                }
            }
        }

        private Global()
        {
            
        }

        public bool DatabaseConnected = false;
    }
}
