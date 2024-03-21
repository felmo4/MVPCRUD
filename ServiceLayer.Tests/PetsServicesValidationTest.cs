using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ServiceLayer.Tests
{
    [Trait("Category", "Model Validations")]
    public class PetsServicesValidationTest : IClassFixture<PetsServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private PetsServicesFixture _petsServicesFixture;

        public PetsServicesValidationTest(PetsServicesFixture petsServicesFixture, ITestOutputHelper testOutputHelper)
        {
            this._petsServicesFixture = petsServicesFixture;    
            _testOutputHelper = testOutputHelper;

            SetValidSampleValues();
        }

        [Fact]
        public void ShouldNotThrowExceptionForDefaultTestValuesOnAnnotations()
        {
            var exception =
                Record.Exception(() => _petsServicesFixture.PetsServices.ValidateModelDataAnnotations
                (_petsServicesFixture.PetsModel));
            Assert.Null(exception);
            WriteExceptionTestResult(exception);
        }

        [Fact]
        public void ShouldThrowExceptionIfAnyDataAnnotationCheckFails()
        {
            _petsServicesFixture.PetsModel.petname = "M";
            _petsServicesFixture.PetsModel.petbday = "";

            Exception exception =
                Assert.Throws<ArgumentException>(testCode: () => _petsServicesFixture.PetsServices.ValidateModelDataAnnotations
                (_petsServicesFixture.PetsModel));

            WriteExceptionTestResult(exception);
        }


        private void SetValidSampleValues()
        {
            _petsServicesFixture.PetsModel.petID = 1;
            _petsServicesFixture.PetsModel.petname = "Momo";
            _petsServicesFixture.PetsModel.petbreed = "Shih Tzu";
            _petsServicesFixture.PetsModel.petbday = "11-04-2017";
        }

        private void WriteExceptionTestResult(Exception exception)
        {
            if (exception != null) 
            { 
                _testOutputHelper.WriteLine(exception.Message);
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                JObject json  = JObject.FromObject(_petsServicesFixture.PetsModel);
                stringBuilder.Append("***** No exception was thrown *****").AppendLine();
                foreach (JProperty jProperty in json.Properties()) 
                {
                    stringBuilder.Append(jProperty.Name).Append(" --> ").Append(jProperty.Value).AppendLine();
                }

                _testOutputHelper.WriteLine(stringBuilder.ToString());
            }
        }

    }
}
