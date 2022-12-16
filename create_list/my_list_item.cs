using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_list
{
    class my_list_item
    {
        public string value;
        public my_list_item Next = null;
        public my_list_item Before = null;
        public my_list_item(string s)
        {
            value = s;
        }
    }
}
