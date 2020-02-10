using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistry
{
    public class Student
    {
        private static uint LastWid = 800;

        public uint Wid;

        public string First;

        public string Last;

        public string Middle;

        public double GPA
        {
            get
            {
                var numerator = 0.0;
                var denominator = 0u;
                foreach (var cr in CourseHistory)
                {
                    if(!cr.InProgress)
                    {
                        numerator += cr.CreditHours * (double)cr.Grade;
                        denominator += cr.CreditHours;
                    }
                }
                return numerator / denominator;
            }
        }

        private List<CourseResult> CourseHistory = new List<CourseResult>();

        public Student(string first, string last, string middle)
        {
            First = first;
            Last = last;
            Middle = middle;
            Wid = LastWid++;
        }

        public override string ToString()
        {
            return $"{Last}, {First} {Middle}, ({Wid}) [{GPA}]";
        }

        public bool EnrollInCourse(Course course)
        {
            var result = new CourseResult(course, course.CreditHours);
            CourseHistory.Add(result);
            return true;
        }

        public bool DropCourse(Course course)
        {
            var record = CourseHistory.Find(cr => cr.course  == course);
            if(record != null && record.InProgress)
            {
                CourseHistory.Remove(record);
                return true;
            }
            return false;  
        }

        public bool CompleteCourse(Course course, Grade grade)
        {
            var record = CourseHistory.Find(cr => cr.course == course);
            if(record != null)
            {
                record.InProgress = false;
                record.Grade = grade;
                return true;
            }
            return false;
        }
    }
}
