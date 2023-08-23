using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class ToaDo
    {
        private int x;
        private int y;
        private string name;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public string Name { get { return name; } set { name = value; } }
        public ToaDo()
        {
            x = 0;
            y = 0;
            name = string.Empty;
        }
        public ToaDo(int tx,int ty,string n)
        {
            x = tx;
            y = ty;
            name = n;
        }
        public override string ToString()
        {
            return name + "(" + x + "," + y + ")";
        }
    }   

}
