using CommonComponents;
using DomainLayer.Models.Pets;
using MySqlConnector;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace InfrastructureLayer.DataAccess.Repositories.Specific.Pets
{
    public class PetsRepository : IPetsRepository
    {
        private string _connectionString;
        public PetsRepository()
        {

        }
        public PetsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(IPetsModel petsModel)
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            using (MySqlConnection mySqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    mySqlConnection.Open();
                }
                catch (MySqlException ex)
                {
                    dataAccessStatus.setValues(
                       status: "Error",
                       operationSucceeded: false,
                       exceptionMessage: ex.Message,
                       customMessage: "Unable to add Pet Model due to unopened database connection",
                       helpLink: ex.HelpLink,
                       errorCode: (int)ex.ErrorCode,
                       stackTrace: ex.StackTrace);

                    throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                }

                string sql = "INSERT INTO tblpets VALUES (DEFAULT, @petname, @petbreed, @petbday)";
                using (MySqlCommand cmd = new MySqlCommand(sql,mySqlConnection))
                {
                    cmd.CommandText = sql;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@petname", petsModel.petname);
                    cmd.Parameters.AddWithValue("@petbreed", petsModel.petbreed);
                    cmd.Parameters.AddWithValue("@petbday", petsModel.petbday);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        dataAccessStatus.setValues(
                            status: "Error",
                            operationSucceeded: false,
                            exceptionMessage: ex.Message,
                            customMessage: "Unable to add Pet Model",
                            helpLink: ex.HelpLink,
                            errorCode: (int)ex.ErrorCode,
                            stackTrace: ex.StackTrace);

                        throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                    }

                    mySqlConnection.Close();
                }
            }
        }
        public void Edit(IPetsModel petsModel)
        {
            int result = -1;
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            using (MySqlConnection mySqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    mySqlConnection.Open();
                }
                catch(MySqlException ex)
                {
                    dataAccessStatus.setValues(
                        status: "Error",
                        operationSucceeded: false,
                        exceptionMessage: ex.Message,
                        customMessage: "Unable to edit Pet Model due to unopened database connection",
                        helpLink: ex.HelpLink,
                        errorCode: (int)ex.ErrorCode,
                        stackTrace: ex.StackTrace);
                    throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                }

                string sql = "UPDATE tblpets SET petname = @petname, petbreed = @petbreed, petbday = @petbday" +
                    "WHERE petID = @petId";

                using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                {
                    try
                    {
                        RecordExistsCheck(cmd, petsModel);
                    }
                    catch (DataAccessException ex)
                    {
                        ex.DataAccessStatusInfo.CustomMessage = "Pet model could not be updated because it is not in the database.";
                        ex.DataAccessStatusInfo.ExceptionMessage = string.Copy(ex.Message);
                        ex.DataAccessStatusInfo.StackTrace = string.Copy(ex.StackTrace);
                        throw ex;
                    }

                    cmd.CommandText = sql;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@petname", petsModel.petname);
                    cmd.Parameters.AddWithValue("@petbreed", petsModel.petbreed);
                    cmd.Parameters.AddWithValue("@petbday", petsModel.petbday);
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        dataAccessStatus.setValues(
                            status: "Error",
                            operationSucceeded: false,
                            exceptionMessage: ex.Message,
                            customMessage: "Unable to update Pet Model",
                            helpLink: ex.HelpLink,
                            errorCode: (int)ex.ErrorCode,
                            stackTrace: ex.StackTrace);

                        throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                    }
                }
                mySqlConnection.Close();
            }
        }
        public void Delete(IPetsModel petsModel)
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            using (MySqlConnection mySqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    mySqlConnection.Open();
                }
                catch (MySqlException ex)
                {
                    dataAccessStatus.setValues(
                        status: "Error",
                        operationSucceeded: false,
                        exceptionMessage: ex.Message,
                        customMessage: "Unable to delete Pet Model due to unopened database connection",
                        helpLink: ex.HelpLink,
                        errorCode: (int)ex.ErrorCode,
                        stackTrace: ex.StackTrace);
                    throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                }

                string sql = "DELETE FROM tblpets WHERE petID = @petId";

                using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                {
                    try
                    {
                        RecordExistsCheck(cmd, petsModel);
                    }
                    catch (DataAccessException ex)
                    {
                        ex.DataAccessStatusInfo.CustomMessage = "Pet model could not be deleted because it is not in the database.";
                        ex.DataAccessStatusInfo.ExceptionMessage = string.Copy(ex.Message);
                        ex.DataAccessStatusInfo.StackTrace = string.Copy(ex.StackTrace);
                        throw ex;
                    }

                    cmd.CommandText = sql;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@petId", petsModel.petID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        dataAccessStatus.setValues(
                            status: "Error",
                            operationSucceeded: false,
                            exceptionMessage: ex.Message,
                            customMessage: "Unable to delete Pet Model",
                            helpLink: ex.HelpLink,
                            errorCode: (int)ex.ErrorCode,
                            stackTrace: ex.StackTrace);

                        throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                    }
                }
                mySqlConnection.Close();
            }
        }
        private bool RecordExistsCheck(MySqlCommand cmd, IPetsModel petsModel)
        {
            Int32 countOfRecsFound = 0;
            bool RecordExistsCheckPassed = true;
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            cmd.Prepare();

            cmd.CommandText = "SELECT count(*) FROM tblpets WHERE petID = @petId";
            cmd.Parameters.AddWithValue("@petId", petsModel.petID);

            try
            {
                countOfRecsFound = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(MySqlException ex)
            {
                string msg = ex.Message;
                throw;
            }

            if (countOfRecsFound == 0)
            {
                dataAccessStatus.Status = "Error";
                RecordExistsCheckPassed = false;
                throw new DataAccessException(dataAccessStatus);
            }

            return RecordExistsCheckPassed;
        }

        public IEnumerable<PetsModel> GetAll()
        {
            List<PetsModel> petsModelList = new List<PetsModel>();
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            using (MySqlConnection mySqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    string sql = "SELECT * from tblpets";
                    mySqlConnection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PetsModel petsModel = new PetsModel();
                                petsModel.petID = Int32.Parse(reader["petID"].ToString());
                                petsModel.petname = reader["petname"].ToString();
                                petsModel.petbreed = reader["petbreed"].ToString();
                                petsModel.petbday = reader["petbday"].ToString();

                                petsModelList.Add(petsModel);
                            }
                        }
                    }
                    mySqlConnection.Close();
                }
                catch (MySqlException ex)
                {
                    dataAccessStatus.setValues(
                        status: "Error",
                        operationSucceeded: false,
                        exceptionMessage: ex.Message,
                        customMessage: "Unable to get Pets Model list from database",
                        helpLink: ex.HelpLink,
                        errorCode: (int)ex.ErrorCode,
                        stackTrace: ex.StackTrace);
                    
                    throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                }

                return petsModelList;
            }
        }
        public PetsModel GetByID(int petId)
        {
            PetsModel petsModel = new PetsModel();
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            bool MatchingRecordsFound = false;
            string sql = "SELECT * FROM tblpets WHERE petID = @petId";

            using (MySqlConnection mySqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    mySqlConnection.Open();

                    using(MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.CommandText = sql;
                        cmd.Prepare();
                        cmd.Parameters.Add(new MySqlParameter("@petId", petId));
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MatchingRecordsFound = reader.HasRows;
                            while (reader.Read())
                            {
                                petsModel.petID = Int32.Parse(reader["petID"].ToString());
                                petsModel.petname = reader["petname"].ToString();
                                petsModel.petbreed = reader["petbreed"].ToString();
                                petsModel.petbday = reader["petbday"].ToString();
                            }

                        }
                    }
                    mySqlConnection.Close();
                }
                catch (MySqlException ex)
                {
                    dataAccessStatus.setValues(
                        status: "Error",
                        operationSucceeded: false,
                        exceptionMessage: ex.Message,
                        customMessage: "Unable to get Pets Model for requested ID",
                        helpLink: ex.HelpLink,
                        errorCode: (int)ex.ErrorCode,
                        stackTrace: ex.StackTrace);
                    
                    throw new DataAccessException(ex.Message, ex.InnerException, dataAccessStatus);
                }
            }

            return petsModel;
        }
    }

}
