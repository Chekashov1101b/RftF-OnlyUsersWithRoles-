using System.ComponentModel.DataAnnotations;
using static RF.Models.Enums.MainSins;

namespace RF.Models.Enums
{
    public class Sin
    {
        public int Id { get; set; }
        [Display(Name = "Родительский грех")]
        public MS MainSin { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Discription { get; set; }
    }
}
