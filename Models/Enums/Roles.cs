using System.ComponentModel.DataAnnotations;

namespace RF.Models.Enums
{
    public class Roles
    {
        public enum roles
        {
            [Display(Name = "Администратор")]
            Admin,
            [Display(Name = "Господин ведущий")]
            GM,
            [Display(Name = "Модератор")]
            Moderator,
            [Display(Name = "Пользователь")]
            User
        }
    }
}
