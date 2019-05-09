using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AzurLane_Organizer.Entities;
using AzurLane_Organizer.Data;

namespace AzurLane_Organizer.Business
{
    public class bCharacter
    {
        private dataCharacter _data = new dataCharacter();

        public bCharacter()
        {

        }

        /// <summary>
        /// Returns a list with all eCharacters in database
        /// Returns null if fails
        /// </summary>
        /// <returns></returns>
        public List<eCharacter> GetCharacters()
        {
            return _data.CharacterSelect();
        }

        /// <summary>
        /// Returns eCharacter with matching CharacterId
        /// in database.
        /// Returns null if fails
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        public eCharacter GetCharacters(int characterId)
        {
            //Gets a list of eCharacter, so it will return
            //the first one, which is the one with
            //the matching CharacterId
            return _data.CharacterSelect(characterId)[0];
        }

        /// <summary>
        /// Gets a list with all eCharacters in database
        /// only with the CharacterId and Name properties.
        /// Returns null if fails.
        /// </summary>
        /// <returns></returns>
        public List<eCharacter> GetCharacterNames()
        {
            return _data.CharacterSelectAllNames();
        }

        /// <summary>
        /// Gets latest eCharacter inserted in database.
        /// Returns null if fails.
        /// </summary>
        /// <returns></returns>
        public eCharacter GetCharacterNewest()
        {
            return _data.CharacterNewest();
        }

        /// <summary>
        /// Inserts a new eCharacter into the database.
        /// Returns number of columns modified.
        /// Returns null if fails.
        /// </summary>
        /// <param name="characterName">
        /// Name of the new character
        /// </param>
        /// <returns></returns>
        public int CharacterCreate(string characterName)
        {
            return _data.CharacterCreate(characterName);
        }

        /// <summary>
        /// Updates the database with the provided
        /// eCharacter information.
        /// Returns null if fails.
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public int CharacterUpdate(eCharacter character)
        {
            return _data.CharacterUpdate(character);
        }

        /// <summary>
        /// Updates the selected character's MainPictureDirectory and
        /// ChibiPictureDirectory in the database.
        /// </summary>
        /// <param name="character">
        /// Character whose information will be updated.
        /// </param>
        /// <returns></returns>
        public int CharacterUpdateImageDirectories(eCharacter character)
        {
            return _data.CharacterUpdateImageDirectories(character);
        }

        /// <summary>
        /// Deletes eCharacter with matching CharacterId
        /// from the database.
        /// Returns null if fails.
        /// </summary>
        /// <param name="characterId">
        /// Deleted eCharacter's CharacterId
        /// </param>
        /// <returns></returns>
        public int CharacterDelete(int characterId)
        {
            return _data.CharacterDelete(characterId);
        }

    }
}
