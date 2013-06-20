using System;

public class CSharpExam : Exam
{
    public int Score { get; private set; }
    public int MaxScore { get; private set; }
    public CSharpExam(int score, int maxScore)
    {
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException("Score can't be less than zero!");
        }
        if (maxScore < score)
        {
            throw new ArgumentOutOfRangeException(string.Format("Score can't be higher than maxScore: {0}", maxScore));
        }
        this.Score = score;
        this.MaxScore = maxScore;
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, this.MaxScore, "Exam results calculated by score.");
    }
}
