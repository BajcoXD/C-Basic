using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Group
    {
        public Group(string name, int numberOfStudents, string classRoomName)
        {
            Name = name;
            NumberOfStudents = numberOfStudents;
            ClassroomName = classRoomName;

        }
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }
        public string ClassroomName { get; set; }

    }
}
