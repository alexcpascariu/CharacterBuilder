using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreationAPI.Models
{
    public class AbilityScores
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1,20)]
        public int Strength { get; set; }
        [Required]
        [Range(1, 20)]
        public int Dexterity { get; set; }
        [Required]
        [Range(1, 20)]
        public int Constitution { get; set; }
        [Required]
        [Range(1, 20)]
        public int Intelligence { get; set; }
        [Required]
        [Range(1, 20)]
        public int Wisdom { get; set; }
        [Required]
        [Range(1, 20)]
        public int Charisma { get; set; }

    }
}
