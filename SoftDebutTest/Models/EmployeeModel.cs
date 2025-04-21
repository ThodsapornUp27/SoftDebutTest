using System.ComponentModel.DataAnnotations;

namespace SoftDebutTest.Models
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "คุณยังไม่ได้กรอกรหัสพนักงาน")]
        public string EmpNum { get; set; } = null!;

        [Required(ErrorMessage = "คุณยังไม่ได้กรอกชื่อพนักงาน")]
        public string? EmpName { get; set; }

        [Required(ErrorMessage = "คุณยังไม่ได้เลือกตำแหน่ง")]
        public string? DepNo { get; set; }
    }
}
