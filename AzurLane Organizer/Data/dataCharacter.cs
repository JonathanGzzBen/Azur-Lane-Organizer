using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using AzurLane_Organizer.Entities;

namespace AzurLane_Organizer.Data
{
    public class dataCharacter
    {
        private List<eCharacter> _charactersList;
        private string _charactersListDirectoryPath = Directory.GetCurrentDirectory() + "\\Characters";
        private string _charactersListFilePath = Directory.GetCurrentDirectory() + "\\Characters\\CharactersList.dat";

        public dataCharacter()
        {
            if (!File.Exists(_charactersListFilePath))
            {
                Directory.CreateDirectory(_charactersListDirectoryPath);
                File.Create(_charactersListFilePath).Dispose();
                _charactersList = new List<eCharacter>();
                SaveCharactersList();
            }
            else
            {
                _charactersList = new List<eCharacter>();
                _charactersList = GenericUtils.ReadFromBinaryFile<List<eCharacter>>(_charactersListFilePath);
                if(_charactersList == null)
                {
                    _charactersList = new List<eCharacter>();
                }
            }
        }

        public void SaveCharactersList()
        {
            GenericUtils.WriteToBinaryFile(_charactersListFilePath, _charactersList);
            return;
        }

        public void RetrieveCharactersList()
        {
            _charactersList = GenericUtils.ReadFromBinaryFile<List<eCharacter>>(_charactersListFilePath);
        }



        public List<eCharacter> CharacterSelect()
        {
            return _charactersList;
        }

        public List<eCharacter> CharacterSelect(int characterId)
        {
            RetrieveCharactersList();
            List<eCharacter> selectedCharacter = (from character in _charactersList
                                                  where character.CharacterId == characterId
                                                  select character).ToList();

            return selectedCharacter;
        }

        public List<eCharacter> CharacterSelectAllNames()
        {
            RetrieveCharactersList();
            if (_charactersList == null)
                return new List<eCharacter>();
            var allCharacterNames = (from character in _charactersList
                                     select character).ToList();
            List<eCharacter> result = new List<eCharacter>();
            foreach(var character in allCharacterNames)
            {
                result.Add(new eCharacter(character.CharacterId, character.Name));
            }
            return result;
        }

        public eCharacter CharacterNewest()
        {
            if(_charactersList.Count == 0)
            {
                return null;
            }

            int newestCharacterId = _charactersList.Max(character => character.CharacterId);
            eCharacter newestCharacter = (from character in _charactersList
                                          where character.CharacterId == newestCharacterId
                                          select character).FirstOrDefault();
            return newestCharacter;
        }

        public int CharacterCreate(string characterName)
        {
            eCharacter latestCharacter = CharacterNewest();
            int newCharacterId;
            if (latestCharacter == null)
                newCharacterId = 1;
            else
                newCharacterId = latestCharacter.CharacterId + 1;

            eCharacter newCharacter = new eCharacter(newCharacterId, characterName);
            _charactersList.Add(newCharacter);
            SaveCharactersList();
            RetrieveCharactersList();
            return 1;
        }

        public int CharacterUpdate(eCharacter characterToUpdate)
        {
            eCharacter oldCharacter = (from character in _charactersList
                                       where character.CharacterId == characterToUpdate.CharacterId
                                       select character).FirstOrDefault();
            oldCharacter = characterToUpdate;
            SaveCharactersList();
            RetrieveCharactersList();
            return 1;
        }

        public int CharacterUpdateImageDirectories(eCharacter characterToUpdate)
        {
            eCharacter oldCharacter = (from character in _charactersList
                                       where character.CharacterId == characterToUpdate.CharacterId
                                       select character).FirstOrDefault();
            oldCharacter.MainPictureDirectory = characterToUpdate.MainPictureDirectory;
            oldCharacter.ChibiPictureDirectory = characterToUpdate.ChibiPictureDirectory;

            SaveCharactersList();
            RetrieveCharactersList();
            return 1;
        }

        public int CharacterDelete(int characterId)
        {
            eCharacter characterToDelete = (from character in _charactersList
                                            where character.CharacterId == characterId
                                            select character).FirstOrDefault();
            _charactersList.Remove(characterToDelete);
            SaveCharactersList();
            RetrieveCharactersList();
            return 1;
        }
    }
}
