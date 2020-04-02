using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreationAPI.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Race { get; set; }
        [Required]
        public int CharacterClassId { get; set; }
        [ForeignKey("CharacterClassId")]
        public CharacterClass Class { get; set; }
        [Required]
        public int AbilityScoresId { get; set; }
        [ForeignKey("AbilityScoresId")]
        public AbilityScores AbilityScores { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
