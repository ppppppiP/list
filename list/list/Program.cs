﻿using list;


        Peoples p = new();
       

bool b = true;

startp:
do
{
    Console.WriteLine("Добавьте элемент в список или закончить добавление?(вводите значения пока не введёте 0") ;

 while (b) 
    {
        string a = Console.ReadLine();
        if(a != "0") 
        { 
    
            p.Add(a);
            
        }
        else
        {
            b = false;
        } 
    }

}while(b);


bool c = true;

do
{
    startc: Console.WriteLine("Вывести все элементы - 1/ удалить элементы - 2/ добавить элементы - 3/ заменить элемент - 4/ добавит элемент в определенное поле - 5/ найти элемент с заданной длинной -6/ вывести элемент по его id - 7");
    int aa = Convert.ToInt32(Console.ReadLine()); 
    switch (aa)
    {
        case 1:
            p.GetAll(); Console.WriteLine("Продолжить операцию? 1/0");
            string da = Console.ReadLine();
            if (da == "0")
            {
                c = false;
            }
            else
            {
                goto startc;
            }
            break;
        case 2:
            Console.WriteLine("Введите имя элемента который хотите удалить");
            string remove = Console.ReadLine();
            p.Remove(remove); Console.WriteLine("Продолжить операцию? 1/0");
            string daa = Console.ReadLine();
            if (daa == "0")
            {
                c = false;
            }
            else
            {
                goto startc;
            }
            break;
        case 3:
            bool bbc = true;
            do
            {
                Console.WriteLine("Добавьте элемент в список или закончить добавление?(вводите значения пока не введёте 0");
                
                while (bbc)
                {
                    string a = Console.ReadLine();
                    if (a != "0")
                    {

                        p.Add(a);

                    }
                    else
                    {
                        bbc = false;
                    }
                }

            } while (bbc); 
            Console.WriteLine("Продолжить операцию? 1/0");
            string dah = Console.ReadLine();
            if (dah == "0")
            {
                c = false;
            }
            else
            {
                goto startc;
            }
            break;

        case 4:
            Console.WriteLine("Введите номер элемента которых хотите заменить и имя нового элемента");
            int ab = Convert.ToInt32(Console.ReadLine());
            string bb = Console.ReadLine();
            p.Update(ab, bb); Console.WriteLine("Продолжить операцию? 1/0");
            string daaa = Console.ReadLine();
            if (daaa == "0")
            {
                c = false;
            }
            else
            {
                goto startc;
            }

            break;
        case 5:
            Console.WriteLine("Введите номер элемента перед которым встанет новый и имя нового элемента");
            int abb = Convert.ToInt32(Console.ReadLine());
            string bbb = Console.ReadLine();
            p.Insert(abb, bbb); Console.WriteLine("Продолжить операцию? 1/0");
            string dac = Console.ReadLine();
            if (dac == "0")
            {
                c = false;
            }
            else
            {
                goto startc;
            }
            break;
        case 6:
            Console.WriteLine("Элемент какой длинны вы хотите найти?");
            int find = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.Find1(find, find));  Console.WriteLine("Продолжить операцию? 1/0");
            string dacc = Console.ReadLine();
            if (dacc == "0")
            {
                c = false;
            }
            else
            {
                goto startc;
            }
            break;
        case 7:
            Console.WriteLine("Введите айди элемента который хотите вывести");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.GetById(id));  Console.WriteLine("Продолжить операцию? 1/0");
            string daccc = Console.ReadLine();
            if (daccc == "0")
            {
                c = false;
            }
            else
            {
                goto startc;
            }
            break;
    }
}while(c);
Console.WriteLine("Вы закончили работу с программой редактирования листа");