using System;

public class SimpleMathExam : Exam
{
    private int problemSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemSolved;
    }

     public int ProblemsSolved 
    { 
        get
        {
            return this.problemSolved;
        }

        private set
        {
            if (value < 0)
            {
                value = 0;
            }

            if (value > 10)
            {
                value = 10;
            }

            this.problemSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: You must pull yourself together.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: You have more to show up.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: You have more to show up..");
        }

        return new ExamResult(0, 0, 0, "Invalid grades entered");
    }
}
