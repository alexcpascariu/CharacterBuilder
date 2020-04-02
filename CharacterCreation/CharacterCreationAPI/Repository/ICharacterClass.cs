using CharacterCreationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreationAPI.Repository
{
    interface ICharacterClass
    {
        CharacterClass GetCharacterClass(int characterClassId);
    }
}
