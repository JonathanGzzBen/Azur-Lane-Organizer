using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurLane_Organizer.Entities
{
    [Serializable]
    public class eCharacter
    {
        private int _characterId;

        public eCharacter()
        {

        }

        public eCharacter(int characterId, string name, string rarity, string index, string faction,
            int idNo, int level, int power, int stars, int affinity, int ranking, string skill1,
            string skill2, string skill3, string skill4, int tier, string buffs, string sinergy,
            string equipment1, string equipment2, string equipment3, string equipment4,
            string mainPictureDirectory, string chibiPictureDirectory)
        {
            this._characterId = characterId;
            this.Name = name;
            this.Rarity = rarity;
            this.Index = index;
            this.Faction = faction;
            this.IdNo = idNo;
            this.Level = level;
            this.Power = power;
            this.Stars = stars;
            this.Affinity = affinity;
            this.Ranking = ranking;
            this.Skill1 = skill1;
            this.Skill2 = skill2;
            this.Skill3 = skill3;
            this.Skill4 = skill4;
            this.Tier = tier;
            this.Buffs = buffs;
            this.Sinergy = sinergy;
            this.Equipment1 = equipment1;
            this.Equipment2 = equipment2;
            this.Equipment3 = equipment3;
            this.Equipment4 = equipment4;
            this.MainPictureDirectory = mainPictureDirectory;
            this.ChibiPictureDirectory = chibiPictureDirectory;
        }

        public eCharacter(int characterId, string name)
        {
            this._characterId = characterId;
            this.Name = name;
        }

        public int CharacterId { get { return _characterId; } }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Index { get; set; }
        public string Faction { get; set; }
        public int IdNo { get; set; }
        public int Level { get; set; }
        public int Power { get; set; }
        public int Stars { get; set; }
        public int Affinity { get; set; }
        public int Ranking { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }
        public int Tier { get; set; }
        public string Buffs { get; set; }
        public string Sinergy { get; set; }
        public string Equipment1 { get; set; }
        public string Equipment2 { get; set; }
        public string Equipment3 { get; set; }
        public string Equipment4 { get; set; }
        public string MainPictureDirectory { get; set; }
        public string ChibiPictureDirectory { get; set; }



    }
}
