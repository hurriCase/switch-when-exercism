using System;
using System.Diagnostics;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => 
        shirtNum switch 
        {
            1 => "goalie",
            2 => "left back",
            3 => "center back",
            4 => "center back",
            5 => "right back",
            6 => "midfielder",
            7 => "midfielder",
            8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException()
        };

    public static string AnalyzeOffField(object report)
    {
        throw new NotImplementedException($"Please implement the (static) PlayAnalyzer.AnalyzeOffField() method");
    }
}
