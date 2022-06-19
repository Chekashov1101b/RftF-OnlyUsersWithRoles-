using System.ComponentModel.DataAnnotations;
using static RF.Models.Enums.MainSins;
using static RF.Models.Enums.HumanLikeRaces;

namespace RF.Data.Entity.Game
{
    public class PlayableCharacter
    {
        //Основные данные
        public int Id { get; set; }
        [Display(Name = "Владелец")]
        public int UserId { get; set; }
        public enum CharStat
        {
            [Display(Name = "Жив(а)")]
            Alive = 0,
            [Display(Name = "Погиб(ла)")]
            Died = 1
        }
        [Display(Name = "Статус")]
        public CharStat CharacterStatus { get; set; } = 0;
        [Display(Name = "Имя")]
        public string CharacterName { get; set; }
        [Display(Name = "Раса")]
        public R CharacterRace { get; set; } = 0;
        [Display(Name = "Уровень")]
        public int Level { get; set; } = 1;
        [Display(Name = "Опыт")]
        public int Exp { get; set; } = 0;
        [Display(Name = "Главный грех")]
        public MS CharacterMainSin { get; set; }
        [Display(Name = "Грех")]
        public int SinId { get; set; }
        public enum Sex
        {
            [Display(Name = "Мужчина")]
            Male = 0,
            [Display(Name = "Женщина")]
            Female = 1
        }
        [Display(Name = "Пол")]
        public Sex CharacterSex { get; set; }
        [Display(Name = "Перк")]
        public int CharacterPerkId { get; set; }
        [Display(Name = "Описание перка")]
        public string CharacterPerkDiscription { get; set; }
        [Display(Name = "Дневник")]
        public string Diary { get; set; }


        //Характеристики
        [Display(Name = "Сила воли")]
        public int WillPower { get; set; }
        [Display(Name = "Свободыне очки характеристик")]
        public int FreeCharacteristicsPoints { get; set; }
        [Display(Name = "Здоровье")]
        public int PointsInHealth { get; set; } = 1;
        [Display(Name = "Сила")]
        public int PointsInStrength { get; set; } = 1;
        [Display(Name = "Скорость")]
        public int PointsInSpeed { get; set; } = 1;
        [Display(Name = "Ловкость")]
        public int PointsInDexterity { get; set; } = 1;
        [Display(Name = "Интеллект")]
        public int PointsInIntellegence { get; set; } = 1;
        [Display(Name = "Восприятие")]
        public int PointsInPerception { get; set; } = 1;
        [Display(Name = "Память")]
        public int PointsInMemory { get; set; } = 1;
        //[Display(Name = "Харизма")]
        //Под вопросом: public int PointsInCharisma { get; set; }


        //Ремёсла
        [Display(Name = "Бесплатных уровней ремёсел")]
        public int FreeCraftLevelPoint { get; set; } = 1;
        [Display(Name = "Уровень Медицины")]
        public int MedicineLevel { get; set; } = 0;
        [Display(Name = "Опыт Медицины")]
        public int MedicineExp { get; set; } = 0;
        [Display(Name = "Уровень Механики")]
        public int MechanicLevel { get; set; } = 0;
        [Display(Name = "Опыт Механики")]
        public int MechanicExp { get; set; } = 0;
        [Display(Name = "Уровень Металлургии")]
        public int MetallurgyLevel { get; set; } = 0;
        [Display(Name = "Опыт Металлургии")]
        public int MetallurgyExp { get; set; } = 0;
        [Display(Name = "Уровень Кузнечного дела")]
        public int BlacksmithingLevel { get; set; } = 0;
        [Display(Name = "Опыт Кузнечного дела")]
        public int BlacksmithingExp { get; set; } = 0;
        [Display(Name = "Уровень Алхимии")]
        public int AlchemyLevel { get; set; } = 0;
        [Display(Name = "Опыт Алхимии")]
        public int AlchemyExp { get; set; } = 0;
        [Display(Name = "Уровень Деревообработки")]
        public int CarpentryLevel { get; set; } = 0;
        [Display(Name = "Опыт Деревообработки")]
        public int CarpentryExp { get; set; } = 0;
        [Display(Name = "Уровень Собирательства")]
        public int GatheringLevel { get; set; } = 0;
        [Display(Name = "Опыт Собирательства")]
        public int GatheringExp { get; set; } = 0;
        [Display(Name = "Уровень Охоты")]
        public int HuntingLevel { get; set; } = 0;
        [Display(Name = "Опыт Охоты")]
        public int HuntingExp { get; set; } = 0;
        [Display(Name = "Уровень Приручения")]
        public int TamingLevel { get; set; } = 0;
        [Display(Name = "Опыт Приручения")]
        public int TamingExp { get; set; } = 0;
        [Display(Name = "Уровень Кулинарии")]
        public int CookingLevel { get; set; } = 0;
        [Display(Name = "Опыт Кулинарии")]
        public int CookingExp { get; set; } = 0;
        [Display(Name = "Уровень Воровства")]
        public int StealingLevel { get; set; } = 0;
        [Display(Name = "Опыт Воровства")]
        public int StealingExp { get; set; } = 0;


        //Владение видами оружия
        [Display(Name = "Свободных очков владения оружием")]
        public int FreeWeaponProficiencyPoints { get; set; } = 2;
        [Display(Name = "Владение Короткими клинками")]
        public int PointsInShortBlades { get; set; } = 0;
        [Display(Name = "Владение Средними клинками")]
        public int PointsInMediumBlades { get; set; } = 0;
        [Display(Name = "Владение Длинными клинками")]
        public int PointsInLongBlades { get; set; } = 0;
        [Display(Name = "Владение Кривыми клинками")]
        public int PointsInCruvedBlades { get; set; } = 0;
        [Display(Name = "Владение Колющим оружием")]
        public int PointsInStabbingWeapon { get; set; } = 0;
        [Display(Name = "Владение рубящим оружием")]
        public int PointsInChoppingWeapon { get; set; } = 0;
        [Display(Name = "Владение Древковым оружием")]
        public int PointsInShaftWeapon { get; set; } = 0;
        [Display(Name = "Владение Метательным оружием")]
        public int PointsInThrowingWeapon { get; set; } = 0;
        [Display(Name = "Владение Гибким оружием")]
        public int PointsInFlexibleWeapon { get; set; } = 0;
        [Display(Name = "Владение Луками")]
        public int PointsInBows { get; set; } = 0;
        [Display(Name = "Владение Арбалетами")]
        public int PointsInCrossbows { get; set; } = 0;
        [Display(Name = "Владение Огнестрельным оружием")]
        public int PointsInFirearms { get; set; } = 0;


        //Данные
        [Display(Name = "Максимальное здоровье")]
        public int MaxHealth { get; set; }
        [Display(Name = "Текущее здоровье")]
        public int Health { get; set; }
        [Display(Name = "Модификатор урона в ближнем бою")]
        public int ModDamageInCC { get; set; }
        [Display(Name = "Модификатор шанса попадания")]
        public int ModChanceAttack { get; set; }
        [Display(Name = "Модификатор шанса уворота")]
        public int ModeChanceDodge { get; set; }
        [Display(Name = "Базовый шанс убеждения")]
        public int PersuasionChance { get; set; }
        [Display(Name = "Модификатор успеха сотворения заклинания")]
        public int ModSuccessMagicCast { get; set; }
        [Display(Name = "Модификатор внимательности")]
        public int ModAttentiveness { get; set; }
        [Display(Name = "Модификатор проверки памяти")]
        public int ModChanceRemember { get; set; }


        //Здоровье
        //Экипировка
        //Инвентарь
    }
}
