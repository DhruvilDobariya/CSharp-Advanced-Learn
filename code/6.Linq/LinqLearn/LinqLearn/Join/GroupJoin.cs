using LinqLearn.Models;

namespace LinqLearn.Join
{
    public class GroupJoin
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee() {EmployeeId = 1, EmployeeName = "Dhruvil Dobariya", CompanyId = 1, CityId = 1 },
            new Employee() {EmployeeId = 2, EmployeeName = "Dhaval Dobariya", CompanyId = 2, CityId = 2 },
            new Employee() {EmployeeId = 3, EmployeeName = "Bhargav Vachhani", CompanyId = 1, CityId = 3 },
            new Employee() {EmployeeId = 4, EmployeeName = "Jenil Vasoya", CompanyId = 3, CityId = 4 },
            new Employee() {EmployeeId = 5, EmployeeName = "Dhruv Rathod", CompanyId = 5, CityId = 5 },
            new Employee() {EmployeeId = 8, EmployeeName = "Shivam Nanda", CompanyId = 2, CityId = 2 },
            new Employee() {EmployeeId = 9, EmployeeName = "Yash Makwana", CompanyId = 5, CityId = 4 },
            new Employee() {EmployeeId = 10, EmployeeName = "Sanjay Vadhiya", CompanyId = 4, CityId = 4 },
            new Employee() {EmployeeId = 6, EmployeeName = "Jash Makwana", CompanyId = 3, CityId = 2 },
            new Employee() {EmployeeId = 7, EmployeeName = "Monik Rupareliya", CompanyId = 4, CityId = 3 }
        };

        private static List<Company> _companies = new List<Company>()
        {
            new Company() { CompanyId = 1, CompanyName = "Microsoft"},
            new Company() { CompanyId = 2, CompanyName = "Samsung"},
            new Company() { CompanyId = 3, CompanyName = "Google"},
            new Company() { CompanyId = 4, CompanyName = "Meta"},
            new Company() { CompanyId = 5, CompanyName = "TCS"},
        };

        public static void Main(string[] args)
        {
            var list1 = from company in _companies
                        join employee in _employees
                        on company.CompanyId equals employee.CompanyId into employees
                        select new { company, employees };

            foreach (var element in list1.ToList())
            {
                foreach (var employee in element.employees)
                {
                    Console.WriteLine($"{employee.EmployeeName} from {element.company.CompanyName}");
                }
            }
            Console.WriteLine();

            var list2 = _companies.GroupJoin(_employees, company => company.CompanyId, employee => employee.CompanyId, (company, employees) => new { company, employees });

            foreach (var element in list2)
            {
                foreach (var employee in element.employees)
                {
                    Console.WriteLine($"{employee.EmployeeName} from {element.company.CompanyName}");
                }
            }
        }
    }
}
