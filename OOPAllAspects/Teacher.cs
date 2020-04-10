using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllAspects
{
    class Teacher : Person
    {
        public List<Student> Students { get;}

        public Teacher(string name) : base(name)
        {
            Students = new List<Student>();
        }

        public override string ToString()
        {
            return "Teacher: " + Name;
        }

        
        public override void Create()
        {
            Console.WriteLine($"The teacher with name: {Name} has been created");
        }

        public override void Read()
        {
            Console.WriteLine($"The teacher details are : {Name}");
        }

        public override void Update()
        {
            Console.WriteLine($"The teacher with name: {Name} has been updated");
        }

        public override void Delete()
        {
            Console.WriteLine($"The teacher with name: {Name} has been deleted");
        }

        public void AssignStudent(Student student)
        {
            Console.WriteLine("The student with name " + student.Name + " has been assigned to Instructor " + Name);
        }
    }
}
