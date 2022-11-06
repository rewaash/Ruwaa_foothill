using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class MyObject
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double avg { set; get; }




        public override string ToString()
        {
            return "Id : " + this.Id + ", Name " + this.Name + ", Avg" + this.avg;
        }
    }
}
