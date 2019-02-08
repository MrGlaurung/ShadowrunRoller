using System;
using System.Collections.Generic;
using System.Linq;
using ShadowRunRoller.Exceptions;

namespace ShadowRunRoller.NPCGeneratorTab.CharacterVault
{
    class CharacterStorage
    {
        #region Properties
        private List<Character.Character> CharactersInVault { get; set; }
        public List<Character.Character> CharsInVault { get{ return CharactersInVault; } set{ return; } }
        #endregion

        #region Constructors
        public CharacterStorage()
        {
            CharactersInVault = new List<Character.Character>();
        }
        #endregion

        #region Class Functions
        public bool RemoveChar(Guid CharIdToRemove)
        {
            if(!CharactersInVault.Select(x => x.Id == CharIdToRemove).Any()) { return false; }

            CharactersInVault = CharactersInVault.Where(x => x.Id != CharIdToRemove).ToList();
            return true;
        }

        public bool AddChar(Character.Character CharToAdd)
        {
            if(CharToAdd.Id == null || string.IsNullOrEmpty(CharToAdd.CharacterAlias)) { throw new IllegalCharacterException("Character not filled in correctly. ID or Alias missing."); }

            // First kill so we can update is already present.
            if (CharactersInVault.Any(x => x.Id == CharToAdd.Id))
            {
                this.RemoveChar(CharToAdd.Id);
            }

            CharactersInVault.Add(CharToAdd);
            return true;
        }

        public Dictionary<Guid, string> GetAllCharsId()
        {
            return ( from f in CharactersInVault select new {f.Id, f.CharacterAlias} ).ToDictionary(x => x.Id, x => x.CharacterAlias);
        }

        public Character.Character FetchCharacter(Guid gu)
        {
            if (!this.Contains(gu)) return null;

            return this.CharsInVault.Find(x => x.Id == gu);
        }

        public bool Contains(Guid gu)
        {
            return this.CharsInVault.Select(x => x.Id == gu).Any();
        }
        #endregion
    }
}
