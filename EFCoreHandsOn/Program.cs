using EFCore.Data;
using EFCore.Data.Entities;



namespace EFCoreHandsOn
{


    public class program
    {
        public static void Main()
        {
           // #region employee
            CrudManagerEmployee employeePerformance = new CrudManagerEmployee();
            // employeePerformance.AddEmployee(new Employee { EmployeeName = "Dipakshi", EmployeeAddress = "Lucknow" });

            //var data = employeePerformance.showAllEmployee();
            //foreach (var emp in data)
            //{
            //    Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
            //}
            //employeePerformance.UpdateEmployee(1, new Employee { EmployeeName = "Aditya Pratap", EmployeeAddress = "Lucknow" });
            //employeePerformance.DeleteEmployeeById(1);
            //var empdata = employeePerformance.showAllEmployee();
            //foreach (var emp in empdata)
            //{
            //    Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
            //}
            //#endregion
            // #region EmpEdu
            List<EmployeeEducation> employeeEducations = new List<EmployeeEducation>();
            employeeEducations.Add(new EmployeeEducation { CourseName = "B.Tech", UniversityName = "BBDEC", PassingYear = 2022, MarksPercentage = 74, EmployeeId = 3 });
            employeeEducations.Add(new EmployeeEducation { CourseName = "B.Tech", UniversityName = "BBDEC", PassingYear = 2022, MarksPercentage = 74, EmployeeId = 3 });
            CrudManagerEmployeeEducation employeeEducation = new CrudManagerEmployeeEducation();
            employeeEducation.AddEmployeeEducation(employeeEducations);
            //var edu = employeeEducation.ShowAllEmpEducation();
            //foreach (var employee in edu)
            //{
            //    //Console.WriteLine("Employee Id : " + employee.Id);
            //    Console.WriteLine("Employee Course Name : " + employee.CourseName);
            //    Console.WriteLine("Employee Passing Year : " + employee.PassingYear);
            //    Console.WriteLine("Employee PerCentage :" + employee.MarksPercentage);
            //    Console.WriteLine();
            //}

            //employeeEducation.updateEmployeeEducation(1, new EmployeeEducation { CourseName = "M.Tech", UniversityName = "BBDNITM", PassingYear = 2021, MarksPercentage = 89, Id = 1 });
            //edu = employeeEducation.ShowAllEmpEducation();
            //foreach (var employee in edu)
            //{
            //    Console.WriteLine("Employee Id : " + employee.Id);
            //    Console.WriteLine("Employee Course Name : " + employee.CourseName);
            //    Console.WriteLine("Employee Passing Year : " + employee.PassingYear);
            //    Console.WriteLine("Employee PerCentage :" + employee.MarksPercentage);
            //    Console.WriteLine();
            //}
            //employeeEducation.deleteEmployeeEducation(2);
            //edu = employeeEducation.ShowAllEmpEducation();
            //foreach (var employee in edu)
            //{
            //    Console.WriteLine("Employee Id : " + employee.Id);
            //    Console.WriteLine("Employee Course Name : " + employee.CourseName);
            //    Console.WriteLine("Employee Passing Year : " + employee.PassingYear);
            //    Console.WriteLine("Employee PerCentage :" + employee.MarksPercentage);
            //    Console.WriteLine();
            //}


        }
    
    }
}

 