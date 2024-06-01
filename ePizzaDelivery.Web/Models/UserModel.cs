using System.ComponentModel.DataAnnotations;

namespace ePizzaDelivery.Web.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Email")]
        public string Email {  get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Re-Enter the same Password")]
        public string ConfirmPassword {  get; set; }

        [Required(ErrorMessage ="Please Enter Phone Number")]
        public string PhoneNumber {  get; set; }
    }
}
