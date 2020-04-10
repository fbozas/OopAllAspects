using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllAspects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Panos Bozas");
            
            Console.WriteLine(person);
            Student student = new Student("Nick Pappas");
            Student student2 = new Student("Nick Alexiou");
            Student student3 = new Student("Peter Pappas");
            Student student4 = new Student("George Pappas");
            Student student5 = new Student("Panos Giannou");
            Student student6 = new Student("Lefteris Pappas");
            Teacher teacher = new Teacher("Tasos Lelakis");
            Teacher teacher1 = new Teacher("George Pasparakis");
            Console.WriteLine(student);
            Console.WriteLine("---------------Inheritance Grouping------------------");

            List<Person> people = new List<Person>();

            people.Add(person);
            people.Add(student);
            people.Add(student2);
            people.Add(student3);
            people.Add(student4);
            people.Add(student5);
            people.Add(student6);
            people.Add(teacher);

            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-----------------Interface Grouping------------------------");

            Product product1 = new Product();
            Product product2 = new Product();

            product1.Name = "Product 1";
            product2.Name = "Product 2";

            product1.Code = "123";
            product1.Description = "Auto to ladi einai fovero";
            product2.Code = "123";
            product2.Description = "Auto to ladi einai fovero";


            List<ICrudable> crudables = new List<ICrudable>();

            crudables.Add(person);
            crudables.Add(student);
            crudables.Add(student2);
            crudables.Add(student3);
            crudables.Add(student4);
            crudables.Add(student5);
            crudables.Add(student6);
            crudables.Add(teacher);
            crudables.Add(product1);
            crudables.Add(product2);

            foreach(ICrudable c in crudables)
            {
                Console.WriteLine(c);
            }


            Console.WriteLine("--------Summarize of object product---------");

            Console.WriteLine("---------------------------Association--------------------------------");
            teacher.AssignStudent(student3);
            student4.HireTeacher(teacher1);

            Console.WriteLine("-------------------------Aggregation------------------------------");
            // List<Student> georgeStudents = new List<Student>();

            //georgeStudents.Add(student5);
            //georgeStudents.Add(student6);

            //teacher1.Students = georgeStudents;

            teacher1.Students.Add(student5);
            teacher1.Students.Add(student6);

            foreach (Student s in teacher1.Students){
                Console.WriteLine(s);
            }

            student3.Teacher = teacher1;

            Console.WriteLine("The teacher of " + student3.Name + " is " + student3.Teacher.Name);

            Console.WriteLine("-------------------------Composition------------------------------");
            List<Student> schoolStudents = new List<Student>();
            //schoolStudents.Add(student);
            //schoolStudents.Add(student2);
            //schoolStudents.Add(student3);
            //schoolStudents.Add(student4);
            //schoolStudents.Add(student5);
            //schoolStudents.Add(student6);

            List<Teacher> schoolTeachers = new List<Teacher>();
            schoolTeachers.Add(teacher);
            schoolTeachers.Add(teacher1);

            School school = new School(schoolStudents, schoolTeachers);
            school.Name = "Coding Bootcamp 10";

            Console.WriteLine(school);


            Console.WriteLine("----------------If we dont have toString()-------------------------");
            // If we dont have stringbuilder
            Console.WriteLine("The school's name is: " + school.Name);
            Console.WriteLine("it's teachers are:");
            foreach (Teacher schoolteacher in school.Teachers)
            {
                Console.WriteLine(schoolteacher.Name);
            }
            Console.WriteLine("it's students are:");
            foreach (Student schoolstudent in school.Students)
            {
                Console.WriteLine(schoolstudent.Name);
            }
        }
    }
}
