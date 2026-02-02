using System.ComponentModel.DataAnnotations;

namespace weeklyprj.Models
{
    public class Employee
    {
        [Key]
        public int ID{get;set;}
        public string Name{get;set;}="";
        public int Salary{get;set;} 
    }
}