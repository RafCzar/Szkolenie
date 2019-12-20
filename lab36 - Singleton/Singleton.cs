using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab36___Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
            Console.WriteLine("tworze Singleton");
        }

        public static Singleton Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
