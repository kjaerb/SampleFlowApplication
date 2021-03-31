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
            new Team { TeamId = "3", Methods = new List<string> { "method42, method17" } },
            new Team { TeamId = "4", Methods = new List<string> { "method4212, method127" } }
        };
    }

    public static ICollection<Team> stubs20()
    {
        return new List<Team> {
            new Team { TeamId = "1", Methods = new List<string> { "method1, method2" } },
            new Team { TeamId = "2", Methods = new List<string> { "method23, method21" } },
            new Team { TeamId = "3", Methods = new List<string> { "method42, method17" } },
            new Team { TeamId = "4", Methods = new List<string> { "method4212, method127" } },
            new Team { TeamId = "5", Methods = new List<string> { "method1, method2" } },
            new Team { TeamId = "6", Methods = new List<string> { "method23, method21" } },
            new Team { TeamId = "7", Methods = new List<string> { "method42, method17" } },
            new Team { TeamId = "8", Methods = new List<string> { "method4212, method127" } },
            new Team { TeamId = "9", Methods = new List<string> { "method42, method17" } },
            new Team { TeamId = "10", Methods = new List<string> { "method4212, method127" } },
            new Team { TeamId = "11", Methods = new List<string> { "method1, method2" } },
            new Team { TeamId = "12", Methods = new List<string> { "method23, method21" } },
            new Team { TeamId = "13", Methods = new List<string> { "method42, method17" } },
            new Team { TeamId = "14", Methods = new List<string> { "method4212, method127" } },
            new Team { TeamId = "15", Methods = new List<string> { "method1, method2" } },
            new Team { TeamId = "16", Methods = new List<string> { "method23, method21" } },
            new Team { TeamId = "17", Methods = new List<string> { "method42, method17" } },
            new Team { TeamId = "18", Methods = new List<string> { "method4212, method127" } },
            new Team { TeamId = "19", Methods = new List<string> { "method42, method17" } },
            new Team { TeamId = "20", Methods = new List<string> { "method4212, method127" } }
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