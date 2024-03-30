using CommonComponents;
using DomainLayer.Models.Pets;
using InfrastructureLayer.DataAccess.Repositories.Specific.Pets;
using Newtonsoft.Json.Linq;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ServiceLayer.Tests
{
    [Trait("Category", "Data Access Validation")]
    public class PetsServicesDataAccessTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private PetsServices _petServices;
        private string _connectionString;
        
        public PetsServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=testcrud";
            _testOutputHelper = testOutputHelper;
            _petServices = new PetsServices(new PetsRepository(_connectionString), new ModelDataAnnotationCheck());
        }

        [Fact]
        public void ShouldReturnListOfPets()
        {
            List<PetsModel> petsModelList = (List<PetsModel>)_petServices.GetAll();
            Assert.NotEmpty(petsModelList);

            foreach (PetsModel pm in petsModelList)
            {
                _testOutputHelper.WriteLine(
                    $"ID: {pm.petID}\n" +
                    $"Name: {pm.petname}\n" +
                    $"Breed: {pm.petbreed}\n" +
                    $"Bday: {pm.petbday}\n");
            }
        }

        [Fact]
        public void ShouldReturnPetModelMatchingID()
        {
            PetsModel petsModel = null;
            int idToGet = 3;

            try
            {
                petsModel = _petServices.GetByID(idToGet);
            }
            catch (DataAccessException ex)
            {
                _testOutputHelper.WriteLine(ex.DataAccessStatusInfo.GetFormattedValues());
            }

            Assert.True(petsModel != null); 
            Assert.True(idToGet == petsModel.petID);

            if(petsModel != null)
            {
                string petsModelJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(petsModel);
                string formattedJsonStr = JToken.Parse(petsModelJsonStr).ToString();
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        public void ShouldReturnSuccessForAdd()
        {
            PetsModel pm = new PetsModel()
            {
                petname = "Chut",
                petbreed = "Pug",
                petbday = "2020/08/20"
            };
            bool operationSucceeded = false;
            string formattedJsonStr = string.Empty;

            try
            {
                _petServices.Add(pm);
                operationSucceeded = true;
            }
            catch(DataAccessException ex)
            {
                operationSucceeded = ex.DataAccessStatusInfo.OperationSucceeded;
                string dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessStatusJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSucceeded);
                _testOutputHelper.WriteLine("The record was successfully added");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }

        }

        [Fact]
        public void ShouldReturnSuccessForDelete()
        {
            PetsModel pm = new PetsModel()
            {
                petID = 1,
                petname = "Uchu",
                petbreed = "Special",
                petbday = "2015/02/15"
            };
            bool operationSucceeded = false;
            string formattedJsonStr = string.Empty;

            try
            {
                _petServices.Delete(pm);
                operationSucceeded = true;
            }
            catch (DataAccessException ex)
            {
                operationSucceeded = ex.DataAccessStatusInfo.OperationSucceeded;
                string dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessStatusJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSucceeded);
                _testOutputHelper.WriteLine("The record was successfully deleted");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        public void ShouldReturnSuccessForUpdate()
        {
            PetsModel pm = new PetsModel()
            {
                petID = 3,
                petname = "Uchu",
                petbreed = "Special Dog",
                petbday = "2015/02/12"
            };
            bool operationSucceeded = false;
            string formattedJsonStr = string.Empty;

            try
            {
                _petServices.Edit(pm);
                operationSucceeded = true;
            }
            catch (DataAccessException ex)
            {
                operationSucceeded = ex.DataAccessStatusInfo.OperationSucceeded;
                string dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessStatusJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSucceeded);
                _testOutputHelper.WriteLine("The record was successfully editted");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }
    }
}
