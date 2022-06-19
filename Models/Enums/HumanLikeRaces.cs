using System.ComponentModel.DataAnnotations;

namespace RF.Models.Enums
{
    public class HumanLikeRaces
    {
        public enum R
        {
            [Display(Name = "Человек")]
            Human = 0,
            [Display(Name = "Человек с острова")]
            IslandHuman = 1,
            [Display(Name = "Дварф")]
            Dwarf = 2,
            [Display(Name = "Ельф")]
            Elf = 3,
        }
    }
}
