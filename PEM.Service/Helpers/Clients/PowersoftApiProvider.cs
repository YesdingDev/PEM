using PEM.Service.Helpers.Integration;
using PEM.Service.Helpers.POCO;
//using Microsoft.Extensions.Options;
//using PEM.Service.DomainModels;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
namespace PEM.Service.Helpers.Clients

{
    //741258 THIS IS THE TOKEN. iT WAS PUT IN THE App settings file. If it doens.t work, that means it has been changed. THe same eason your login does not work on this same app
    public class PowersoftApiProvider : IPowersoftApiProvider
    {
        private readonly IntegrationHelper _intergrationHelper;
        //private readonly QueryStringBuilder _queryStringBuilder;
        private readonly Uri _apiBaseUri;
        private readonly string _token;
        private readonly string bearerToken;
        private int sessionTimeout;
        private readonly APIsettings _applicationSettings;
        private readonly SessionTimeout _applicationSettings1;
        private readonly ILogger<PowersoftApiProvider> logger;
        private string _queryString = "";

        public PowersoftApiProvider(IOptions<APIsettings> _applicationSettingsAccessor,
            IOptions<SessionTimeout> _applicationSettingsAccessor1, ILogger<PowersoftApiProvider> logger)
        {
            try
            {
                _applicationSettings = _applicationSettingsAccessor.Value;
                _applicationSettings1 = _applicationSettingsAccessor1.Value;
                _apiBaseUri = new Uri(_applicationSettings.WebApiBaseUrl);
                _token = _applicationSettings.Initializer;
                bearerToken = _applicationSettings.BearerToken;
                sessionTimeout = _applicationSettings1.Timeout;
                _intergrationHelper = new IntegrationHelper(_apiBaseUri);

            }
            catch (Exception ex)
            {

            }

            this.logger = logger;
        }

        public async Task<StatusMessage> ResetPassword(string username)
        {
            StatusMessage result;
            try
            {
                var requestUrl = _intergrationHelper.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    APIEndpointUrl.ResetCustomerPassword + "/" + username + "/" + _token));

                result = await _intergrationHelper.GetAsync<StatusMessage>(requestUrl);

            }

            catch (Exception e)
            {
                throw;
            }
            return result;
        }

        public async Task<StatusMessage> Login(string username, string password)
        {
            StatusMessage result = new StatusMessage();

            try
            {
                if (username == null)
                {
                    result.status = "Failed";
                    result.message = "Username cannot be empty";
                }
                else if (password == null)
                {
                    result.status = "Failed";
                    result.message = "Password cannot be empty";
                }
                else
                {
                    var requestUrl = _intergrationHelper.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    "api/" + APIEndpointUrl.Login + "/" + _token), "?username=" + username + "&password=" + password);

                    result = await _intergrationHelper.GetAsync<StatusMessage>(requestUrl);
                }

            }
            catch (Exception ex)
            {
                result.status = "Failed";
                result.message = ex.Message;
            }

            return result; // Tuple.Create(sessionTimeout, result);
        }

        public async Task<Response<IEnumerable<PFAType>>> GetAllPFAType()
        {
            try
            {
                var requestUrl = _intergrationHelper.CreateRequestUri($"{APIEndpointUrl.GetAllPFAType}/{_token}");

                var result = await _intergrationHelper
                    .GetAsync<Response<IEnumerable<PFAType>>>(requestUrl: requestUrl, bearerToken: bearerToken);

                return result;

            }

            catch (Exception e)
            {
                logger.LogError($"there is an error getting PFA Type || {e.Message}");
                throw;
            }
        }

        /*
                public async Task<Response<IEnumerable<Attendance>>> GetAllAttendance()
                {
                    try
                    {
                        var requestUrl = _intergrationHelper.CreateRequestUri("api/" + $"{APIEndpointUrl.GetAllAttendance}/{_token}");

                        var result = await _intergrationHelper
                            .GetAsync<Response<IEnumerable<Attendance>>>(requestUrl: requestUrl, bearerToken: bearerToken);

                        return result;

                    }

                    catch (Exception e)
                    {
                        logger.LogError($"there is an error getting Attendance || {e.Message}");
                        throw;
                    }
                }*/
       


        public async Task<StatusMessage> GetAllAttendance()
        {
            StatusMessage result = new StatusMessage();

            try
            {

                var requestUrl = _intergrationHelper.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "api/" + APIEndpointUrl.GetAllAttendance + "/" + _token));

                result = await _intergrationHelper.GetAsync<StatusMessage>(requestUrl: requestUrl, bearerToken: bearerToken);

            }
            catch (Exception ex)
            {
                result.status = "Failed";
                result.message = ex.Message;
            }

            return result;
        }


        public async Task<Response<IEnumerable<AbseteeismReportSummary>>> GetAllAbseteeismReportSummary()
        {
            try
            {
                var requestUrl = _intergrationHelper.CreateRequestUri($"{APIEndpointUrl.GetAllAbseteeismReportSummary}/{_token}");

                var result = await _intergrationHelper
                    .GetAsync<Response<IEnumerable<AbseteeismReportSummary>>>(requestUrl: requestUrl, bearerToken: bearerToken);

                return result;

            }
            catch (Exception e)
            {

                logger.LogError($"there is an error getting absenteeismReportSummary || {e.Message}");
                throw;
            }
        }
        public async Task<Response<IEnumerable<AbsenteeismReportDetail>>> GetAllAbsenteeismReportDetail()
        {
            try
            {
                var requestUrl = _intergrationHelper.CreateRequestUri($"{APIEndpointUrl.GetAllAbsenteeismReportDetail}/{_token}");
                var result = await _intergrationHelper
                   .GetAsync<Response<IEnumerable<AbsenteeismReportDetail>>>(requestUrl: requestUrl, bearerToken: bearerToken);

                return result;
            }
            catch (Exception e)
            {

                logger.LogError($"there is an error getting absenteeismReportDetail || {e.Message}");
                throw;
            }
        }
        public async Task<Response<IEnumerable<DeductionReport>>> GetAllDeductionReport()
        {
            try
            {
                var requestUrl = _intergrationHelper.CreateRequestUri($"{APIEndpointUrl.GetAllDeductionReport}/{_token}");
                var result = await _intergrationHelper
                    .GetAsync<Response<IEnumerable<DeductionReport>>>(requestUrl: requestUrl, bearerToken: bearerToken);
                return result;
            }
            catch (Exception e)
            {
                logger.LogError($"there is an error getting DeductionReport || {e.Message}");
                throw;
            }

        }
        public async Task<Response<IEnumerable<LatenessReportDetails>>> GetAllLatenessReportDetails()
        {
            try
            {
                var requestUrl = _intergrationHelper.CreateRequestUri($"{APIEndpointUrl.GetAllLatenessReportDetails}/{_token}");
                var result = await _intergrationHelper
                    .GetAsync<Response<IEnumerable<LatenessReportDetails>>>(requestUrl: requestUrl, bearerToken: bearerToken);
                return result;
            }
            catch (Exception e)
            {
                logger.LogError($"there is an error getting LatenessReportDetails || {e.Message}");
                throw;
            }
        }
    }

}
