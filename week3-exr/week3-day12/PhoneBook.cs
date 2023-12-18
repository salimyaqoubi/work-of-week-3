using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day12
{
    internal class PhoneBook
    {
        public static int cnt;
        string[] Names;
        long[] Numbers;
        int size;

        public PhoneBook(int size)
        {
            this.size = size;
            this.Names = new string[size];
            this.Numbers = new long[size];
        }


        public int GetSize()
        {
            return size;
        }

        public void addPerson(int order, string name, long number)
        {
            this.Names[cnt] = name;
            this.Numbers[cnt] = number;
            cnt += 1;
        }


        public void GetAll()
        {
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < this.size; i++)
            {
                if (this.Numbers[i] > 0)
                    Console.WriteLine($"{this.Names[i]} || {this.Numbers[i]}");
            }
        }

        public long GetNumByName(string name)
        {
            for (int i = 0; i < size; i++)
            {
                if (this.Names[i] == name)
                {
                    return this.Numbers[i];
                }
            }
            return 0;
        }
        public long this[string Names]
        {
            get
            {
                for (int i = 0;i < this.size; i++)
                {
                    if (this.Names[i] == Names)
                    {
                        return Numbers[i];
                    }
                }
                return 0;
            }
            set
            {
                this.Names[cnt] = Names;
                this.Numbers[cnt] = value;
                cnt += 1;
            }
        }
    }
}
