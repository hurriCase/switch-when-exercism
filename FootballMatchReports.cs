using System;
using System.Diagnostics;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => 
        shirtNum switch 
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException()
        };

    public static string AnalyzeOffField(object report) =>
        report switch
        {
            Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
            Incident incident => incident.GetDescription(),
            Manager manager when manager.Club != null => $"{manager.Name} ({manager.Club})",
            Manager manager => $"{manager.Name}",
            string str => str,
            int number => $"There are {number} supporters at the match.",
            _ => throw new ArgumentException()
        };
}
