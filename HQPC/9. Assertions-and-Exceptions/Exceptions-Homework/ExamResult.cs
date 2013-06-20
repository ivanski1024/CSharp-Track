﻿using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade shouldn't be less than zero!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minimum grade shouldn't be less than zero!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("The maximum grade should be higher than the minimum!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("There shoud be comments on the grade!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
