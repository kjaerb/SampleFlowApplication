using System;
using System.Collections.Generic;
public class SourceDepartment
{
    public string Classification {get; set;} // Sample type in all caps INDATA

    public string SourceDepartmentId {get; set;} // Formerly U_SourceDept

    public static SourceDepartment getSourceDepartmentById(string dept_id, ICollection<SourceDepartment> SourceDepList)
    {
        foreach (var sdep in SourceDepList)
        {
            if (sdep.SourceDepartmentId.Equals(dept_id)) return sdep; 
            
        }
        return null; 
    }
    
    public static ICollection<SourceDepartment> stubs()
    {
        return new List<SourceDepartment> {
            new SourceDepartment { Classification = "4355", SourceDepartmentId = "c17"},
            new SourceDepartment { Classification = "1337", SourceDepartmentId = "c17"},
            new SourceDepartment { Classification = "0420", SourceDepartmentId = "c17"}
        };
    }
}