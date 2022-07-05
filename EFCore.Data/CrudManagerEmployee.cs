using EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class CrudManagerEmployee
    {
        DemoDbContext context;
        public CrudManagerEmployee()
        {
            context = new DemoDbContext();
        }
        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();

        }
        public List<Employee> showAllEmployee()
        {
            return context.Employees.Include(e => e.employeeEducation).ToList();
        }
        public Employee GetEmployeeById(int EmployeeId)
        {
            Employee employee = new Employee();
            var emp = context.Employees.Where(x => x.EmployeeId == EmployeeId).Include(e => e.employeeEducation).FirstOrDefault();
            if (emp == null)
            {
                Console.WriteLine("record Not Found {0}", EmployeeId);
                employee.EmployeeName = "not Found";

            }
            else
            {
                employee = emp;
            }

            return employee;
        }
        public void UpdateEmployee(int EmployeeId, Employee employee)
        {
            var updateEmp = context.Employees.Where(x => x.EmployeeId == EmployeeId).Include(e => e.employeeEducation).FirstOrDefault();
            if (updateEmp == null)
            {
                Console.WriteLine("no record Found with this id = {0} to be  Update ", EmployeeId);

            }
            else
            {
                updateEmp.EmployeeName = employee.EmployeeName;
                updateEmp.EmployeeAddress = employee.EmployeeAddress;
                //updateEmp.employeeEducation = edu;
                context.Employees.Update(updateEmp);
                context.SaveChanges();

            }
        }
        public void DeleteEmployeeById(int id)
        {
            var deleteEmp = context.Employees.Where(x => x.EmployeeId == id).Include(e => e.employeeEducation).FirstOrDefault();
            if (deleteEmp == null)
            {
                Console.WriteLine($"No record Found whth id  {id}");
            }
            else
            {
                deleteEmp.employeeEducation.Clear();
                context.Employees.Remove(deleteEmp);
                context.SaveChanges();
                Console.WriteLine("DELETED");
            }

        }
       
       
    }
}
