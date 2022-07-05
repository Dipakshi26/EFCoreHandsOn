using EFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class CrudManagerEmployeeEducation
    {
        DemoDbContext context;
        public CrudManagerEmployeeEducation()
        {
            context = new DemoDbContext();
        }
        //public void AddEmployeeEducation(EmployeeEducation employeeEducation)
        //{
        //    context.EmployeeEducations.Add(employeeEducation);
        //    context.SaveChanges();
        //    Console.WriteLine("done...");
        //}
        public void AddEmployeeEducation(List<EmployeeEducation> educationList)
        {
            context.EmployeeEducations.AddRange(educationList);
            context.SaveChanges();
        }
        public void deleteEmployeeEducation(int id)
        {
            var deleteeducation = context.EmployeeEducations.Where(edu => edu.Id == id).FirstOrDefault();
            if (deleteeducation != null)
            {
                context.EmployeeEducations.Remove(deleteeducation);
                context.SaveChanges();
                Console.WriteLine("Delete Employee Education ");
            }
            else
            {
                Console.WriteLine("Data Not found To be Delete with Id= {0}", id);
            }
        }
        public void updateEmployeeEducation(int EmployeeId, EmployeeEducation employeeEducation)
        {
            var updateEducation = context.EmployeeEducations.Where(edu => edu.Id == EmployeeId).FirstOrDefault();
            if (updateEducation != null)
            {
                updateEducation.CourseName = employeeEducation.CourseName;
                updateEducation.UniversityName = employeeEducation.UniversityName;
                updateEducation.MarksPercentage = employeeEducation.MarksPercentage;
                updateEducation.PassingYear = employeeEducation.PassingYear;
                context.EmployeeEducations.Update(updateEducation);
                context.SaveChanges();
                Console.WriteLine("Updated...");

            }
            else
            {
                Console.WriteLine(" No record Found With ID= {0}", EmployeeId);
            }
        }
        public List<EmployeeEducation> ShowAllEmpEducation()
        {
            var listEducation = context.EmployeeEducations.ToList();
            return listEducation;
        }

    }
}

