using CharacterCreationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreationAPI.Repository
{
    interface ICharacter
    {
        Character GetCharacter(int characterId);
        bool CreateCharacter(Character character);
        bool UpdateCharacter(Character character);
        bool DeleteCharacater(Character character);
        bool Save();
    }
}
