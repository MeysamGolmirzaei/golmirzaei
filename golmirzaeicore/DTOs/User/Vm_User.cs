using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace golmirzaeiCore.DTOs.User
{
    public class Vm_User
    {
        public int Vm_Id { get; set; }


        [DisplayName("نام کاربری")]
        [Required(ErrorMessage ="پر کردن این فیلد اجباری می باشد")]
        [DataType(DataType.Text , ErrorMessage = "ورودی باید رشته باشد")]
        public string Vm_Name { get; set; }


        [DisplayName("نام خانوادگی")]
        [Required(ErrorMessage ="پر کردن این فیلد اجباری می باشد")]
        [DataType(DataType.Text , ErrorMessage = "ورودی باید رشته باشد")]
        public string Vm_Family { get; set; }


        public bool Vm_Status { get; set; }


        [DisplayName("رمز عبور")]
        [Required(ErrorMessage ="پر کردن این فیلد اجباری می باشد")]
        [DataType(DataType.Password)]
        public string Vm_Password { get; set; }
        
        
        [DisplayName("تکرار رمز عبور")]
        [Required(ErrorMessage ="پر کردن این فیلد اجباری می باشد")]
        [DataType(DataType.Password)]
        [Compare("Vm_Password",ErrorMessage = "رمز عبور با تکرار آن مطابقت ندارد")]
        public string Vm_RePassword { get; set; }
    }
}