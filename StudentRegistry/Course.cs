using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry
{
    public class Course : IEquatable<Course>
    {
        public uint Number;

        public uint CreditHours;

        public string Name;

        public string Semester;

        public bool Equals(Course course)
        {
            return course.Number == Number;
        }
    }
}