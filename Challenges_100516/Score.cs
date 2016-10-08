using System;

public class Score
{
    internal int score { get; private set; }
    internal void increaseScore()
    {
        this.score++;

    }
    private void decreaseScore()
    {
        this.score--;

    }
}

public class SomeEvilProgram
{
    public static void Main()
    {
        Score score = new Score();
        Console.WriteLine(score.score);
        score.score = 9000;
    }
}