//Case Study 1
using com.lti.casestudy.day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    class App
    {

        static void Main()
        {
            scenario1();
        }
        static void scenario1()
        {
            Student st1 = new Student();
            Console.WriteLine("ID is " + st1.id);
            Console.WriteLine("Name is " + st1.name);
            st1.id = 10;
            st1.name = "Ajay";
            st1.dateOfBirth = Convert.ToDateTime("12/10/2020");
            Student st2 = new Student();
            st2.id = 10;
            st2.name = "Ajay";
            st2.dateOfBirth = Convert.ToDateTime("12/10/2020");
            info in1 = new info();
            in1.Display(st1);
            in1.Display(st2);
        }

        // Scenario 2
        // Array of Student Class
        static void scenario2()
        {
            //int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 8, 4, 5 ,90};
            Student[] s = new Student[10] {
              new Student() { id = 1, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 2, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 3, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 4, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 1, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 2, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 3, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 4, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 1, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
              new Student() { id = 2, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") }

            };
            info in1 = new info();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    in1.Display(s[i]);
            //}
            in1.Display(s);

        //    s = new Student[10]
        //    {
        //      s[0]=   new Student() { id = 1, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[1]=   new Student() { id = 2, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[2]=   new Student() { id = 3, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[3]=   new Student() { id = 4, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[4]=   new Student() { id = 1, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[5]=   new Student() { id = 2, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[6]=   new Student() { id = 3, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[7]=   new Student() { id = 4, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[8]=   new Student() { id = 1, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") },
        //      s[9]=   new Student() { id = 2, name = "Deepak", dateOfBirth = Convert.ToDateTime("12/12/2020") }
              

        //};

          


    }
        static void Scenaio3()
        {
            int id;
            string name;
            DateTime dateOfBirth;

            Student[] s = new Student[10];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter ID");
                id = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("ENter Name");
                name = Console.ReadLine();
                Console.WriteLine("ENter Date Of Birth");
                dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                s[i] = new Student() { id = id, name = name, dateOfBirth = dateOfBirth };
            }
            info in1 = new info();
            for (int i = 0; i < s.Length; i++)
            {
                in1.Display(s[i]);
            }

        }
        static void Scenario4()
        {

        }


        //  in1.Display(s);

        //    // Scenario 4

        //    int id;
        //    string name;
        //    for (int i = 0; i < 2; i++)
        //    {
        //        Console.WriteLine("Enter ID");
        //        id = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter Name");
        //        name = Console.ReadLine();
        //        s[i] = new Student(id, name);
        //        s[i].Display();

        //    }
        //    for (int i = 0; i < 2; i++)
        //    {
        //        s[i] = new Student(1, "Ajay");
        //        s[i].Display();

        //    }


        //}
    }
    }
}


 