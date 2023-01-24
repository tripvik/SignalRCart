using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRCart
{
    public class CartCount
    {
        internal static int count = 0;

        public static int Count
        {
            get { return count; }
        }

        public static void Add()
        {
            count++;
        }

        public static void Remove()
        {
            count--;
        }
    }
}