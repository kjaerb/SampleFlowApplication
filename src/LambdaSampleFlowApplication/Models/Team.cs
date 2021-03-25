using System;
using System.Collections.Generic;

public class Team 
{
    public string TeamId { get; set; } 
    public List<string> Methods { get; set; } 

    public static Team stub()
    {
        return new Team { TeamId = "1", Methods = new List<string> { "method1, method2" } };
    }

    public static ICollection<Team> stubs()
    {
        return new List<Team> {
            new Team { TeamId = "1", Methods = new List<string> { "method1, method2" } },
            new Team { TeamId = "2", Methods = new List<string> { "method23, method21" } },
            new Team { TeamId = "3", Methods = new List<string> { "method42, method17" } }
        };
    }

        public static Team getTeamById(string id, ICollection<Team> teamList)
    {
        foreach (var t in teamList)
        {
            if (t.TeamId.Equals(id))
            {
                return t; 
            }
        }
        return null;
    }
}