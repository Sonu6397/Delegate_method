using System;
namespace GeeksForGeeks
{

  
    class Geeks
    {

        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

      
        public void sum(int a, int b)
        {
            Console.WriteLine("Addition="+( a + b));
        }

       
        public void subtract(int a, int b)
        {
            Console.WriteLine("sabtruction="+ (a - b));
        }

       
        public static void Main(String[] args)
        {

            Geeks obj = new Geeks();

           
            addnum obj1 = new addnum(obj.sum);
            subnum obj2 = new subnum(obj.subtract);

           
            obj1(100, 40);
            obj2(100, 60);

           
        }
    }
}