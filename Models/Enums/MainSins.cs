using System.ComponentModel.DataAnnotations;

namespace RF.Models.Enums
{
    public class MainSins
    {
        public enum MS
        {
            [Display(Name = "Похоть")]
            Lust = 0,
            [Display(Name = "Обжорство")]
            Gluttony = 1,
            [Display(Name = "Жадность")]
            Greed = 2,
            [Display(Name = "Лень")]
            Sloth = 3,
            [Display(Name = "Гнев")]
            Wrath = 4,
            [Display(Name = "Зависть")]
            Envy = 5,
            [Display(Name = "Гордыня")]
            Pride = 6
        }
    }
}
