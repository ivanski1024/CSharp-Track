using System;

public class SimpleMathExam : Exam
{
    public int ProblemsSolved { get; private set; }
    public int AllProblemsCount { get; private set; }

    public SimpleMathExam(int problemsSolved, int allProblemsCount)
    {
        if (problemsSolved < 0)
        {
            throw new ArgumentOutOfRangeException("The count of problems solved can't be less than zero!");
        }
        if (problemsSolved > allProblemsCount)
        {
            throw new ArgumentOutOfRangeException("The count of the solved problems can't be bigger than the count of all problems!");
        }

        this.ProblemsSolved = problemsSolved;
        this.AllProblemsCount = allProblemsCount;
    }

    public override ExamResult Check()
    {
        float coeficient = this.ProblemsSolved / this.AllProblemsCount;

        if (coeficient < 0.25)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (coeficient < 0.5)
        {
            return new ExamResult(3, 2, 6, "Low result: something done.");
        }
        else if (coeficient < 0.75)
        {
            return new ExamResult(4, 2, 6, "Average result: half of it done.");
        }
        else if (coeficient < 0.9)
        {
            return new ExamResult(5, 2, 6, "Good result: most of done.");
        }

        return new ExamResult(6, 2, 6, "Excellent result: everything done.");
    }
}
