using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{ class Peoples
    {
        List<string> peoples = new List<string>();


        public void Add(string a)
        {
            peoples.Add(a);

        }
        public void Remove(string p)
        {
            peoples.Remove(p);
            Console.WriteLine("~Deleted");
        }
        public string GetById(int id)
        {
            return "элемент с айди "+ id+" "+ peoples[id];
        }
        public void Insert(int id, string p)
        {
            peoples.Insert(id, p);

        }
        public void Update(int id, string p)
        {
            peoples.RemoveRange(id, 1);
            peoples.Insert(id, p); 
        }
        public string Find1(int p, int condition)
        {
           if( peoples.Exists( p => p.Length == condition))// проверяю есть ли элемент с заданным условием длинны
            {
                return peoples.Find(p => p.Length == condition);
            }
            else
            {
                return "Такого имени нет в списке";
            }

        }
public void GetAll()
        {
            foreach(string p in peoples)
            {
                Console.WriteLine(p);
            }
        }
    }
}

