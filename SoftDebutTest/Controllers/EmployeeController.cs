using Microsoft.AspNetCore.Mvc;
using SoftDebutTest.Models;

namespace SoftDebutTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly MasterDbContext _context;

        public EmployeeController(ILogger<EmployeeController> logger, MasterDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult FirstEmployee()
        {
            Employee employee = _context.Employees.FirstOrDefault();
            ViewBag.Message = employee.EmpName;
            return View();
        }

        public IActionResult AddEmployee()
        {
            List<Department> departments = GetDepartments();
            ViewBag.Departments = departments;
            return View(new EmployeeModel());
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeModel employee)
        {
            List<Department> departments = GetDepartments();
            ViewBag.Departments = departments;

            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            Employee addEmployee = new Employee()
            {
                EmpNum = employee.EmpNum,
                EmpName = employee.EmpName,
                DepNo = employee.DepNo,
            };

            _context.Employees.Add(addEmployee);
            _context.SaveChanges();


            ViewBag.Message = "เพิ่มข้อมูลพนักงานเรียบร้อยแล้ว!";
            ViewBag.EmpNum = employee.EmpNum;
            ViewBag.EmpName = employee.EmpName;
            ViewBag.DepName = departments.Where(w => w.DepNo == employee.DepNo).Select(w => w.DepName).FirstOrDefault();


            return View(employee);
        }

        private List<Department> GetDepartments()
        {
            List<Department> departments = _context.Departments.ToList();
            return departments;
        }
    }
}
