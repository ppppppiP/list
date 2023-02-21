using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class People 
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public  int Age { get; set;  }
        public People(int id, string name, int age) {
            Id = id;
            Name = name;
            
            Age = age;
        }
        public override string ToString()
        {
            return String.Format("Id {0)"+
                "Name {1}"+
                "Age {2}", Id, Name, Age);
        }
       
    }
}
