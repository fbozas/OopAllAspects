using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllAspects
{
    class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        private void SetStudentFromCmd()
        {
            Console.WriteLine("Give student's name");
            string studentName = Console.ReadLine();
            Students.Add(new Student(studentName));
        }

        public School(List<Student> students, List<Teacher> teachers)
        {
            Students = students;
            Teachers = teachers;
            if (!Students.Any())
            {
                Console.WriteLine("The school does not have students");
                SetStudentFromCmd();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("The school's name is: ");
            sb.Append(Name);
            sb.Append("\n");
            sb.Append("it's teachers are: ");
            foreach(Teacher teacher in Teachers)
            {
                sb.Append("\n");
                sb.Append(teacher);
            }
            sb.Append("\n");
            sb.Append("and it's students are:");
            foreach(Student student in Students)
            {
                sb.Append("\n");
                sb.Append(student);
            }
            return sb.ToString();
        }
    }
}
