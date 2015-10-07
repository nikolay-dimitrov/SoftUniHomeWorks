using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new NullReferenceException("The score cannot be less then 0");
        }

        this.Score = score;
    }

    public int Score 
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (this.Score < 0 || this.Score > 100)
            {
                throw new InvalidOperationException("The score cannot be less then 0 and more then 100");
            }
            this.score = value;
        }
    }

    public override ExamResult Check()
    {

        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
