using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreationAPI.Models
{
    public class CharacterClass
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int Level { get; set; }
    }
}
