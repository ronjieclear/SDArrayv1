using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            //students list
            //0. 
            //1. 
            //2. 
            //3. 
            //4. 
            
            //assigning value in the array
            students[0] = "ronjie";
            students[1] = "Michael";
            students[2] = "Kent";
            students[3] = "Kyla";
            students[4] = "Andrea";
            //students list
            //0. ronjie
            //1. Michael
            //2. Kent
            //3. Kyla
            //4. Andrea


            //students[1] = 11; - error - int cant be stored in string array

            //try to add new value to the string 
            //students[5] = "Zedrick"; //error out of range due to size limit of the array

            //Resize the array to create additional 3 slots
            Array.Resize(ref students, students.Length + 3); ///5 + 3
            //students list
            //0. - ronjie
            //1. - Michael
            //2. - Kent
            //3. - Kyla
            //4. - Andrea
            //5. 
            //6.
            //7. 

            //Try to add another value to the array
            students[5] = "Zedrick";
            //students list
            //0. - ronjie
            //1. - Michael
            //2. - Kent
            //3. - Kyla
            //4. - Andrea
            //5. - Zedrick
            //6.
            //7.


            //Creating a dynamic size array at the same time assigning a value
            string[] names = new string[] {"Everlyn","Gimima","Jamie"};
            //names list
            //0. - Everlyn
            //1. - Gimima
            //2. - Jamie

            //To display or access the value of an array
            //Console.WriteLine(students[0]);
            //Console.WriteLine(students[1]);
            //Console.WriteLine(students[2]);
            //Console.WriteLine(students[3]);
            //Console.WriteLine(students[4]);
            //Console.WriteLine(students[5]);

            int al = students.Length;   //get the size of the array and save to al

            //show the value of the array using a loop
            /* int i = 0;
            do
            {
                Console.WriteLine(students[i]);
                i++;
            } while (i < al);*/

/*            for(int i = 0;i<al;i++)
            {
                Console.WriteLine(students[i]);
            }*/

/*            int i = 0;
            while (i<=al)
            {
                Console.WriteLine(students[i]);
                i++;
            }*/

            //For each loop - dedicated for the array
            foreach(string v in students)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();



        }
    }
}
 