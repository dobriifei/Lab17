using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Modelirovanie<T>
    {
        public T Num { get; set; }
        public string Fio { get; set; }
        public int Balance { get; set; }

        public Modelirovanie(T num, string fio, int balance)
        {
            Num = num;
            Fio = fio;
            Balance = balance;
        }

        public string GetInfo()
        {
            return $"{Num} {Fio} {Balance}";
        }


    }
}
