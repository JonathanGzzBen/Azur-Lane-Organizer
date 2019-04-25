using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.Common;
using System.Data;
using AzurLane_Organizer.Entities;

namespace AzurLane_Organizer.Data
{
    class dataCharacter
    {
        public dataCharacter()
        {

        }

        private static string _connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["AzurLane_Organizer.Properties.Settings.Azur_Lane_OrganizerConnectionString"].ConnectionString; }
        }

        private static string _provider
        {
            get { return ConfigurationManager.ConnectionStrings["AzurLane_Organizer.Properties.Settings.Azur_Lane_OrganizerConnectionString"].ProviderName; }
        }

        private DbProviderFactory _dbpFactory
        {
            get { return DbProviderFactories.GetFactory(_provider); }
        }

        public List<eCharacter> CharacterSelectAll()
        {
            return ExecuteDataReader("spALCharactersSelectAll");
        }

        public List<eCharacter> CharacterSelectAll(int characterId)
        {
            List<DbParameter> parameters = new List<DbParameter>();
            DbParameter parameter1 = _dbpFactory.CreateParameter();
            parameter1.ParameterName = "CharacterId";
            parameter1.Value = characterId;
            parameters.Add(parameter1);
            return ExecuteDataReader("spALCharacterSelectCharacter", parameters);
        }

        public List<eCharacter> CharacterSelectAllNames()
        {
            return ExecuteDataReaderSimple("spALCharacterSelectNames");
        }

        public eCharacter CharacterNewest()
        {
            List<eCharacter> lstCharacters = ExecuteDataReader("spALCharacterSelectNewestToOldest");
            return lstCharacters[0];
        }

        public int CharacterCreate(string characterName)
        {
            List<DbParameter> lstParameters = new List<DbParameter>();
            DbParameter parameter1 = _dbpFactory.CreateParameter();
            parameter1.ParameterName = "Name";
            parameter1.Value = characterName;
            lstParameters.Add(parameter1);
            return ExecuteNonQuery("spALCharacterInsert", lstParameters);
        }

        public int CharacterUpdate(eCharacter character)
        {
            List<DbParameter> lstParameters = new List<DbParameter>();

            DbParameter parameter1 = _dbpFactory.CreateParameter();
            parameter1.ParameterName = "CharacterId";
            parameter1.Value = character.CharacterId;
            lstParameters.Add(parameter1);

            DbParameter parameter2 = _dbpFactory.CreateParameter();
            parameter2.ParameterName = "Name";
            parameter2.Value = character.Name;
            lstParameters.Add(parameter2);

            DbParameter parameter3 = _dbpFactory.CreateParameter();
            parameter3.ParameterName = "Rarity";
            parameter3.Value = character.Rarity;
            lstParameters.Add(parameter3);

            DbParameter parameter4 = _dbpFactory.CreateParameter();
            parameter4.ParameterName = "Index";
            parameter4.Value = character.Index;
            lstParameters.Add(parameter4);

            DbParameter parameter5 = _dbpFactory.CreateParameter();
            parameter5.ParameterName = "Faction";
            parameter5.Value = character.Faction;
            lstParameters.Add(parameter5);

            DbParameter parameter6 = _dbpFactory.CreateParameter();
            parameter6.ParameterName = "IdNo";
            parameter6.Value = character.IdNo;
            lstParameters.Add(parameter6);

            DbParameter parameter7 = _dbpFactory.CreateParameter();
            parameter7.ParameterName = "Level";
            parameter7.Value = character.Level;
            lstParameters.Add(parameter7);

            DbParameter parameter8 = _dbpFactory.CreateParameter();
            parameter8.ParameterName = "Power";
            parameter8.Value = character.Power;
            lstParameters.Add(parameter8);

            DbParameter parameter9 = _dbpFactory.CreateParameter();
            parameter9.ParameterName = "Stars";
            parameter9.Value = character.Stars;
            lstParameters.Add(parameter9);

            DbParameter parameter10 = _dbpFactory.CreateParameter();
            parameter10.ParameterName = "Affinity";
            parameter10.Value = character.Affinity;
            lstParameters.Add(parameter10);

            DbParameter parameter11 = _dbpFactory.CreateParameter();
            parameter11.ParameterName = "Ranking";
            parameter11.Value = character.Ranking;
            lstParameters.Add(parameter11);

            DbParameter parameter12 = _dbpFactory.CreateParameter();
            parameter12.ParameterName = "Skill1";
            parameter12.Value = character.Skill1;
            lstParameters.Add(parameter12);

            DbParameter parameter13 = _dbpFactory.CreateParameter();
            parameter13.ParameterName = "Skill2";
            parameter13.Value = character.Skill2;
            lstParameters.Add(parameter13);

            DbParameter parameter14 = _dbpFactory.CreateParameter();
            parameter14.ParameterName = "Skill3";
            parameter14.Value = character.Skill3;
            lstParameters.Add(parameter14);

            DbParameter parameter15 = _dbpFactory.CreateParameter();
            parameter15.ParameterName = "Skill4";
            parameter15.Value = character.Skill4;
            lstParameters.Add(parameter15);

            DbParameter parameter16 = _dbpFactory.CreateParameter();
            parameter16.ParameterName = "Tier";
            parameter16.Value = character.Tier;
            lstParameters.Add(parameter16);

            DbParameter parameter17 = _dbpFactory.CreateParameter();
            parameter17.ParameterName = "Buffs";
            parameter17.Value = character.Buffs;
            lstParameters.Add(parameter17);

            DbParameter parameter18 = _dbpFactory.CreateParameter();
            parameter18.ParameterName = "Sinergy";
            parameter18.Value = character.Sinergy;
            lstParameters.Add(parameter18);

            DbParameter parameter19 = _dbpFactory.CreateParameter();
            parameter19.ParameterName = "Equipment1";
            parameter19.Value = character.Equipment1;
            lstParameters.Add(parameter19);

            DbParameter parameter20 = _dbpFactory.CreateParameter();
            parameter20.ParameterName = "Equipment2";
            parameter20.Value = character.Equipment2;
            lstParameters.Add(parameter20);

            DbParameter parameter21 = _dbpFactory.CreateParameter();
            parameter21.ParameterName = "Equipment3";
            parameter21.Value = character.Equipment3;
            lstParameters.Add(parameter21);

            DbParameter parameter22 = _dbpFactory.CreateParameter();
            parameter22.ParameterName = "Equipment4";
            parameter22.Value = character.Equipment4;
            lstParameters.Add(parameter22);

            DbParameter parameter23 = _dbpFactory.CreateParameter();
            parameter23.ParameterName = "MainPictureDirectory";
            parameter23.Value = character.MainPictureDirectory;
            lstParameters.Add(parameter23);

            DbParameter parameter24 = _dbpFactory.CreateParameter();
            parameter24.ParameterName = "ChibiPictureDirectory";
            parameter24.Value = character.ChibiPictureDirectory;
            lstParameters.Add(parameter24);

            return ExecuteNonQuery("spALCharacterUpdate", lstParameters);

        }

        public int CharacterDelete(int characterId)
        {
            List<DbParameter> lstParameters = new List<DbParameter>();
            DbParameter parameter1 = _dbpFactory.CreateParameter();
            parameter1.ParameterName = "CharacterId";
            parameter1.Value = characterId;
            lstParameters.Add(parameter1);
            return ExecuteNonQuery("spALCharacterDelete", lstParameters);
        }

        private int ExecuteNonQuery(string storedProcedure, List<DbParameter> parameters = null)
        {
            int id = 0;
            try
            {
                using (DbConnection connection = _dbpFactory.CreateConnection())
                using (DbCommand cmd = _dbpFactory.CreateCommand())
                {
                    connection.ConnectionString = _connectionString;
                    cmd.Connection = connection;
                    cmd.CommandText = storedProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;


                    if (parameters != null)
                    {
                        foreach (DbParameter parameter in parameters)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                    }

                    connection.Open();
                    id = cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }
            return id;
        }

        private List<eCharacter> ExecuteDataReader(string storedProcedure, List<DbParameter> parameters = null)
        {
            List<eCharacter> lstCharacters = new List<eCharacter>();
            try
            {
                using (DbConnection con = _dbpFactory.CreateConnection())
                using (DbCommand cmd = _dbpFactory.CreateCommand())
                {
                    con.ConnectionString = _connectionString;
                    cmd.Connection = con;
                    cmd.CommandText = storedProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;


                    if (parameters != null)
                    {
                        foreach (DbParameter parameter in parameters)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                    }

                    con.Open();
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstCharacters.Add(new eCharacter(
                                (int)reader["CharacterId"],
                                (string)reader["Name"],
                                (string)reader["Rarity"],
                                (int)reader["Index"],
                                (string)reader["Faction"],
                                (int)reader["IdNo"],
                                (int)reader["Level"],
                                (int)reader["Power"],
                                (int)reader["Stars"],
                                (int)reader["Affinity"],
                                (int)reader["Ranking"],
                                (string)reader["Skill1"],
                                (string)reader["Skill2"],
                                (string)reader["Skill3"],
                                (string)reader["Skill4"],
                                (int)reader["Tier"],
                                (string)reader["Buffs"],
                                (string)reader["Sinergy"],
                                (string)reader["Equipment1"],
                                (string)reader["Equipment2"],
                                (string)reader["Equipment3"],
                                (string)reader["Equipment4"],
                                (string)reader["MainPictureDirectory"],
                                (string)reader["ChibiPictureDirectory"]));
                        }
                        return lstCharacters;
                    }
                }
            }
            catch
            {
                return null;
            }
        }


        private List<eCharacter> ExecuteDataReaderSimple(string storedProcedure, List<DbParameter> parameters = null)
        {
            List<eCharacter> lstCharacters = new List<eCharacter>();
            try
            {
                using (DbConnection con = _dbpFactory.CreateConnection())
                using (DbCommand cmd = _dbpFactory.CreateCommand())
                {
                    con.ConnectionString = _connectionString;
                    cmd.Connection = con;
                    cmd.CommandText = storedProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                if(parameters != null)
                {
                    foreach (DbParameter parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }



                    con.Open();
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstCharacters.Add(new eCharacter(
                                (int)reader["CharacterId"],
                                (string)reader["Name"]));
                       
                        }
                        return lstCharacters;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
