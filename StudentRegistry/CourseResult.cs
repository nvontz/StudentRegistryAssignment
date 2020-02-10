using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry
{
    public class CourseResult
    {
        public Course course;

        public uint CreditHours;

        public Grade Grade;

        public bool InProgress;

        public CourseResult(Course course, uint hours)
        {
            this.course = course;
            this.CreditHours = hours;
            this.InProgress = true;
        }
    }
}
