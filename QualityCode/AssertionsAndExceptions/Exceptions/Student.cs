using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstName;

    private string lastName;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (this.firstName == null)
            {
                throw new ArgumentNullException("You have entered an empty First Name");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (this.lastName == null)
            {
                throw new ArgumentNullException("You have entered an empty Last Name");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("You have entered an empty exam name");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("The student has no exams!");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("Cannot calculate average on missing exams");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("The student has no exams!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade)
                           / (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}