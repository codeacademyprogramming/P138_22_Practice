using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Student
    {
        public string FullName;
        public string Group;
        public List<Exam> Exams = new List<Exam>();

        public override string ToString()
        {
            return FullName + " - " + Group;
        }

        public List<Exam> GetExamsByPointRange(byte minPoint,byte  maxPoint)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.Point >= minPoint && item.Point <= maxPoint)
                    wantedExams.Add(item);
            }

            return wantedExams;
        }

        public List<Exam> GetExamsByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.StartAt>=fromDate && item.FinishAt<=toDate)
                    wantedExams.Add(item);
            }

            return wantedExams;
        }

        public double GetAvgPoint()
        {
            double sum = 0;
            foreach (var item in Exams)
            {
                sum += item.Point;
            }

            return sum / Exams.Count;
        }

        public double GetTotalExamMinutes()
        {
            double totalMinutes = 0;
            foreach (var item in Exams)
            {
                var diff = item.FinishAt - item.StartAt;
                totalMinutes += diff.TotalMinutes;
            }

            return totalMinutes;
        }
    }
}
