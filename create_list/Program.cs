using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_list
{
    class Program
    {
        static void Main(string[] args)
        {
            my_list ml = new my_list("a");
            string st = "bc";
            for (int i =0; i < st.Length; i++)
            {
                ml.append(Convert.ToString(st[i]));
            }
            my_list m2 = new my_list("r");
            string stt = "rrr";
            for (int i = 0; i < stt.Length; i++)
            {
                m2.append(Convert.ToString(stt[i]));
            }
            ml.print();
            m2.print();
            //Console.WriteLine(ml.len);
            Console.WriteLine(" ");
            //Console.WriteLine(ml.k_for_end(0));           
            //Console.WriteLine(ml.is_palindrom());
            //ml.reverse();
            //ml.print();
            //my_list_item it_del = ml.elem_for_end(1);
            //ml.delete_without_head(it_del);
            //ml.delete_double();
            my_list m_new = ml + m2;
            m_new.print();

        }

    }
}
