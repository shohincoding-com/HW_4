using System;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            double money;
            Console.WriteLine("Please enter a purchase amount!");
            money = double.Parse(Console.ReadLine());
            if(money < 500){
                Console.WriteLine("No discount!\nEndTask_1");
            }
            else if(money > 499 && money < 999){
                Console.WriteLine($"Discount {money / 100 * 3} $!\nEndTask_1");
            }
            else{
                Console.WriteLine($"Discount {money / 100 * 5} $!\nEndTask_1");
            }
            //EndTask_1

            //Task_2
            double A1, A2, A3, A4, min = 0.0;
            Console.WriteLine("A1 = ");
            A1 = double.Parse(Console.ReadLine());
            Console.WriteLine("A2 = ");
            A2 = double.Parse(Console.ReadLine());
            Console.WriteLine("A3 = ");
            A3 = double.Parse(Console.ReadLine());
            Console.WriteLine("A4 = ");
            A4 = double.Parse(Console.ReadLine());
            bool a =!(A1 < A2 && A2 < A3 && A3 < A4);
            if(a){
                if(A1 == A2 && A2 == A3 && A3 == A4){
                    Console.WriteLine($"{A1} * {A2} * {A3} * {A4} = {A1 * A2 * A3 * A4}\nEndTask_2");
                }
                else{ 
                if(A1<=A2 && A1<=A3 && A1<=A4) min=A1;
                if(A2<=A1 && A2<=A3 && A2<=A4) min=A2;
                if(A3<=A1 && A3<=A2 && A3<=A4) min=A3;
                if(A4<=A1 && A4<=A2 && A4<=A3) min=A4;
                Console.WriteLine($"min({A1}, {A2}, {A3}, {A4}) = {min}\nEndTask_2");
                }
            }
            else {
                Console.WriteLine("Число расположены по возрастанию\nEndTask_2");
            }
            //EndTask_2

            //Task_3
            int A, B, C, D;
            Console.WriteLine("a = ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            C = int.Parse(Console.ReadLine());
            if (B >= A && A >= C){D = A; A = B; B = D;}
            else if(C >= A && A >= B) {D = A; A = C; C = B; B = D;}
            else if(C >= B && B >= A) {D = A; A = C; C = D;}
            else if(A >= B && B <= C) {D = B; B = C; C = D;}
            else if(B >= A && A <= C) {D = A; A = B; B = C; C = D;}
            Console.WriteLine($"{A}, {B}, {C};\nEndTask_3");
            //EndTask_3
        }
    }
}
