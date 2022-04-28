using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixing_test
{
    class Box
    {
        private string name;
        private int cal;
        private int fat;

        public Box(string name, int cal, int fat)
        {
            this.name = name;
            this.cal = cal;
            this.fat = fat;
        }

        public bool IsHelthy()
        {
            return this.cal < 130 && this.fat < 5;
        }
        public int GetCal()
        {
            return this.cal;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
