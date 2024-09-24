using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        ASGCalculator Cal = new ASGCalculator();

        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();


        List<double> assignmentScores = new List<double>();
        Console.WriteLine("Assignment Scores: ");
        for (int i = 0; i < 3; i++)
            {
                double assignment = double.Parse(Console.ReadLine());
                assignmentScores.Add(assignment);
            }

        List<double> quizScores = new List<double>();
        Console.WriteLine("Quiz Scores: ");
        for (int i = 0; i < 3; i++)
            {
                double quiz = double.Parse(Console.ReadLine());
            quizScores.Add(quiz);
            }

        Console.Write("Final Exam Score: ");
        double finalExamScore = double.Parse(Console.ReadLine());

        double weightedAverage = Cal.CalculateWeightedAverage(assignmentScores, quizScores, finalExamScore);



    }
}

public class ASGCalculator 
{
    public double CalculateWeightedAverage(List<double> assignments, List<double> quizzes, double finalExam)
    {
        double assignmentWeight = 0.4;
        double quizWeight = 0.3;
        double finalExamWeight = 0.3;

        double assignmentTotal = 0;
        foreach (double score in assignments)
        {
            assignmentTotal += score;
        }
        double assignmentAverage = assignmentTotal / assignments.Count;

        double quizTotal = 0;
        foreach (double score in quizzes)
        {
            quizTotal += score;
        }
        double quizAverage = quizTotal / quizzes.Count;

        return (assignmentAverage * assignmentWeight) + (quizAverage * quizWeight) + (finalExam * finalExamWeight);
    }



}