using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    public class SampleApiCall: ISampleApiCall
    {
        public async Task<object> GetPostDetails(string PersonListUrl)
        {
            try
            {
                var httpclient = new HttpClient();
                var placeresults = await httpclient.GetAsync(PersonListUrl);
                var response = placeresults.Content.ReadAsStringAsync().Result;
                if (placeresults.IsSuccessStatusCode)
                {
                    if (placeresults.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                       // var FinalData = JsonConvert.DeserializeObject<RootObject>(response);
                        return response;
                    }
                }
            }
            catch (Exception e)
            {
                var except = e.Message;
            }
            return null;
        }
    }
}
