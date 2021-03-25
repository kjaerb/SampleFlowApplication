using System;
using System.Collections.Generic;

public class Sample
{
    //Originally prefixed with 'S_'
    public string SampleId { get; set; }

    public string ParamListId { get; set; } // Method

    public ModificationDate ModificationDate { get; set; } //Have all the dates for the samples

    //Originally prefixed with 'S_'
    public string QCBatchId { get; set; }

    //Originally prefixed with 'U_'
    public string SamepleUnit { get; set; } //This can maybe be made into Enums? Limited amount of units

    //Originally prefixed with 'U_'
    public string SampleInfo { get; set; }

    //Originally prefixed with 'U_'
    public string ProductName { get; set; }

    public Team Team { get; set; }

    public static ICollection<Sample> getSampleByTeamId(string id, ICollection<Sample> sampleList)
    {
        List<Sample> returnList = new List<Sample>(); 
        foreach (var s in sampleList)
        {
            if (s.Team.TeamId.Equals(id))
            {
                returnList.Add(s); 
            }
        }
        return returnList; 
    }

    public static Sample getSampleById(string id, ICollection<Sample> sampleList)
    {
        foreach (var s in sampleList)
        {
            if (s.SampleId.Equals(id))
            {
                return s; 
            }
        }
        return null;
    }

    public static Sample stub()
    {
        return new Sample
        {
            SampleId = "S-20200822-00025",
            ParamListId = "B307-10",
            ModificationDate = new ModificationDate
            {
                AUDITSEQUENCE = 3,
                status = Enum.Intial,
                MODDT = new DateTime(),
                COLLECTIONDT = new DateTime(),
                RECEIVEDDT = new DateTime(),
                CREATEDT = new DateTime(),
                COMPLETEDT = new DateTime(),
                SUBMITTEDDT = new DateTime(),
                REVIEWEDDT = new DateTime(),

            },
            Team = Team.stub(),
            QCBatchId = "QB-20200825-00188",
            ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
        };
    }

    public static ICollection<Sample> stubs()
    {

        return new List<Sample>
        {
            new Sample
            {
                SampleId = "S-20200822-00025",
                ParamListId = "B307-10",
                ModificationDate = new ModificationDate
                {
                    AUDITSEQUENCE = 3,
                    status = Enum.Intial,
                    MODDT = new DateTime(),
                    COLLECTIONDT = new DateTime(),
                    RECEIVEDDT = new DateTime(),
                    CREATEDT = new DateTime(),
                    COMPLETEDT = new DateTime(),
                    SUBMITTEDDT = new DateTime(),
                    REVIEWEDDT = new DateTime(),

                },
                Team = Team.stub(),
                QCBatchId = "QB-20200825-00188",
                ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
            },

            new Sample
            {
                SampleId = "S-20200822-00028",
                ParamListId = "222325_Sema-GIP",
                ModificationDate = new ModificationDate
                {
                    AUDITSEQUENCE = 8,
                    status = Enum.InProgress,
                    MODDT = new DateTime(),
                    COLLECTIONDT = new DateTime(),
                    RECEIVEDDT = new DateTime(),
                    CREATEDT = new DateTime(),
                    COMPLETEDT = new DateTime(),
                    SUBMITTEDDT = new DateTime(),
                    REVIEWEDDT = new DateTime()
                },
                Team = Team.stub(),
                QCBatchId = "QB-20200825-00188",
                ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
            },

            new Sample
            {
                SampleId = "S-20200822-00020",
                ParamListId = "222325_Sema-GIP",
                ModificationDate = new ModificationDate
                {
                    AUDITSEQUENCE = 7,
                    status = Enum.Received,
                    MODDT = new DateTime(),
                    COLLECTIONDT = new DateTime(),
                    RECEIVEDDT = new DateTime(),
                    CREATEDT = new DateTime(),
                    COMPLETEDT = new DateTime(),
                    SUBMITTEDDT = new DateTime(),
                    REVIEWEDDT = new DateTime()
                },
                Team = Team.stub(),
                QCBatchId = "QB-20200825-00188",
                ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
            }
        };
    }
}