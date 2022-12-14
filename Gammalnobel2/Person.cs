using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalnobel2
{
    class Person
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public bool IsWinner { get; set; } 

        public int Year { get; set; }

        public override string ToString()
        {
            if (IsWinner == true)
            {
                if (Year == 2022)
                {
                    return $"{Firstname} {Lastname} - Nybliven vinnare";
                }
                else
                {
                    return $"{Firstname} {Lastname} - {2022 - Year} år sedan";
                }
            }
            else
            {
                return $"{Firstname} {Lastname}";
            }
        }
    }
}
