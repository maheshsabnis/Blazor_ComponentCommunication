using System;
using System.Collections.Generic;

namespace Blazor_ComponentCommunication.Models
{
    public class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() {EmpNo=101, EmpName="Mahesh", Designation="Manager", Salary=72000, DeptName="SALES"  });
            Add(new Employee() { EmpNo = 102, EmpName = "Vikram", Designation = "Architect", Salary = 92000, DeptName = "IT" });
            
        }
    }
}
