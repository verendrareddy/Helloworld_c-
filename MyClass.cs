using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication //namspace declararation
{
    public class MyClass // clas declaaration
    {
        int i = 9; //data member of class

        private int rollno = 20;

        int a, b;
        public  MyClass(int x, int y)
        {
            a = x;
            b=y;
        }
        public  MyClass(MyClass m)
        {
            a = m.a;
            b = m.b;
        }

        public int RollNo
        {
            get
            {
                return rollno;
            }

            set
            {
                rollno = value;
            }
        }

       
        
        
        public void PrintNum()
        {
            Console.WriteLine("Rollnum is {0}", rollno);
        }
        public void HelloWorld()  //method defintiion
        {
            Console.WriteLine("Hello world");
        }

        public void Datatype()
        {
            int a;
            double d = 34.567;
            a = (int)d;
            Console.WriteLine(a);

            short s = 90;
            int c;
            c = s;
            Console.WriteLine(c);



            
        }


    }
    public class Myclass2
    {
       
        
    }

    
}
