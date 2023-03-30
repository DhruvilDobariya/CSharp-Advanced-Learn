using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Join
{
    public class Join
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

        private static List<City> _cities = new List<City>()
        {
            new City() { CityId = 1, CityName = "Los Angeles"},
            new City() { CityId = 2, CityName = "New York"},
            new City() { CityId = 3, CityName = "London"},
            new City() { CityId = 4, CityName = "Ahmedabad"},
            new City() { CityId = 5, CityName = "Rajkot"},
        };

        public static void Main(string[] args)
        {
            var list1 = from employee in _employees
                        join company in _companies
                        on employee.CompanyId equals company.CompanyId
                        join city in _cities
                        on employee.CityId equals city.CityId
                        select new
                        {
                            EmployeId = employee.EmployeeId,
                            CompanyName = company.CompanyName,
                            CityName = city.CityName,
                            EmployeeName = employee.EmployeeName
                        };
            Display.Table(list1.ToList());

            var list2 = _employees
                .Join(_companies, employee => employee.CompanyId, company => company.CompanyId, (employee, company) => (employee, company))
                .Join(_cities, employeeWithCompany => employeeWithCompany.employee.CityId, city => city.CityId, (employeeWithCompany, city) => new {
                    EmployeId = employeeWithCompany.employee.EmployeeId,
                    CompanyName = employeeWithCompany.company.CompanyName,
                    CityName = city.CityName,
                    EmployeeName = employeeWithCompany.employee.EmployeeName,
                });

            Display.Table(list2.ToList());

        }
    }
}
