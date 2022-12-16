using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_list
{
    class my_list
    {
        public my_list_item head = new my_list_item("");
        public my_list() { }
        public my_list(string s) { head.value = s; len += 1; }
        public void append(string st)
        {
            my_list_item temp = this.head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            my_list_item elem = new my_list_item(st);
            temp.Next = elem;
            len += 1;
        }
        public void print()
        {
            my_list_item temp = head;
            while (temp.Next != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.Next;
            }
            Console.WriteLine(temp.value);
        }
        public int len;
        public string k_for_end(int k)
        {
            my_list_item temp = head;
            int ind = 0;
            while ((ind + k) != len)
            {
                temp = temp.Next;
                ind += 1;
            }
            return temp.value;
        }
        public my_list_item elem_for_end(int k)
        {
            my_list_item temp = head;
            int ind = 0;
            while ((ind + k) != len)
            {
                temp = temp.Next;
                ind += 1;
            }
            return temp;
        }
        public bool is_palindrom()
        {
            bool flag = true;
            my_list_item temp = head;
            int ind = 1;
            while (temp.Next != null)
            {
                if (temp.value != k_for_end(ind))
                {
                    flag = false;
                }
                temp = temp.Next;
                ind += 1;
            }
            return flag;
        }
        public void reverse()
        {
            my_list_item last = null;
            my_list_item now = head;
            my_list_item next = null;
            while (now.Next != null)
            {
                next = now.Next;
                now.Next = last;
                last = now;
                now = next;
            }
            now.Next = last;
            head = now;
        }
        public void delete_without_head(my_list_item elem)
        {
            if (elem.Next == null)
            {
                elem = null;
            }
            else
            {
                while (elem.Next != null)
                {
                    elem.value = elem.Next.value;
                    if (elem.Next.Next == null)
                    {
                        elem.Next = null;
                        break;
                    }
                    elem = elem.Next;
                }
            }
        }
        public void delete_double()
        {
            my_list_item current = head;
            while (current != null)
            {
                my_list_item temp = current;
                while (temp.Next != null)
                {
                    if (temp.Next.value == current.value)
                    {
                        temp.Next = temp.Next.Next;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                current = current.Next;
            }
        }

        public static my_list operator +(my_list my_list1, my_list my_list2)
        {
            my_list my_list3 = new my_list(my_list1.head.value);
            my_list_item tempp = my_list3.head;
            my_list_item runner = my_list1.head.Next;
            my_list_item runner2 = my_list2.head;
            while (runner != null)
            {
                tempp.Next = runner;
                runner = runner.Next;
                tempp = tempp.Next;
            }
            for (int i = my_list2.len; i > 0; i--)
            {
                my_list3.append(my_list2.k_for_end(i));
            }
            //while (runner2 != null)
            //{
            //    tempp.Next = runner2;
            //    runner2 = runner2.Next;
            //    tempp = tempp.Next;
            //}
            return my_list3;
        }
    }
}
