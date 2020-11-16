using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetMessage()
        {
            return "こんにちは! 今" + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string TextHello()
        {
            return "こんにちは! 今" + DateTime.Now.ToLongTimeString();
        }
    }
}
