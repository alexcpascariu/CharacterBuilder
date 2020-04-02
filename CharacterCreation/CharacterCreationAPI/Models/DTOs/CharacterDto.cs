using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreationAPI.Models.DTOs
{
    public class CharacterDto
    {
        public int Id { get; set; }
        [Required]
        public string Race { get; set; }
        [Required]
        public int AbilityScoresId { get; set; }
        public AbilityScores AbilityScores { get; set; }
        [Required]
        public int CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }
}
