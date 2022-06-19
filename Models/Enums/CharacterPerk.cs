using System.ComponentModel.DataAnnotations;

namespace RF.Models.Enums
{
    public class CharacterPerk
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Discription { get; set; }
    }
}
