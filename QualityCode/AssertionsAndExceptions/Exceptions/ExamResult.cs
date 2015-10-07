using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
      
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (grade < 0)
            {
                throw new ArgumentNullException("The grade cannot be less then 0");
            }
            this.grade = value;
        }
    }

    public int MinGrade 
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (minGrade < 0)
            {
                throw new ArgumentNullException("The minimal grade cannot be less then 0");
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (maxGrade <= minGrade)
            {
                throw new ArithmeticException("The minimum grade cannot be greater or equal then maximum grade");
            }
            this.maxGrade = value;
        }
    }

    public string Comments 
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (string.IsNullOrEmpty(comments))
            {
                throw new ArgumentNullException("You must add atlest 1 symbol to the comments");
            }
            this.comments = value;
        }
    }
}
