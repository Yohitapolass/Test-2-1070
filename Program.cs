using System;

namespace WS1 {
class Program {
    
// หาตัวเลขที่มากที่สุด โดยใช่ If 1 ครั้ง /// find Max Number with one if
        static int Max2(int a, int b) {

            if( a > b ){
                return a;
            }
            return b;

         }

         static int CheckN(int N,int K){
            
           if( N > 1 || N <= 10000 || K >= 1 || K <= 1000 ){
                return N;
                return K;
            
            }
            

         }

         static void Main(string []args){

             
            Console.Write("  ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("  ");
            int K = int.Parse(Console.ReadLine());

            Console.Write("  ");
            int Sex = int.Parse(Console.ReadLine());
            Console.Write("  ");
            int Point1 = int.Parse(Console.ReadLine());
             Console.WriteLine("  ");
            int Point1 = int.Parse(Console.ReadLine());


            Console.WriteLine(finalResult);
        

         }
         
//////////////////////////////////////////////////////////////////////////////

    }
}