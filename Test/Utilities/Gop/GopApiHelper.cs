using System;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;
using Test.Utilities.Gop;

namespace Test.Utilities
{
    public static class GopApiHelper
    {
        /// <summary>
        ///     Help to sending a rest API request.
        /// </summary>
        /// <param name="apiUrl">the api's url</param>
        /// <param name="requestName">the api's name</param>
        /// <param name="apiKey">the key of the api</param>
        /// <param name="searchContent">searching content</param>
        /// <param name="filters">filters applied</param>
        /// <returns></returns>
        public static dynamic Execute(string apiUrl, string requestName, string apiKey, string searchContent,
            params Filter[] filters)
        {
            var client = new RestClient(apiUrl);
            var request = new RestRequest(requestName, Method.GET);
            request.AddHeader("Accept", @"application/json, text/javascript, */*; q=0.01");
            if (!string.IsNullOrWhiteSpace(searchContent)) request.AddParameter("q", searchContent);
            if (filters != null)
            {
                foreach (var filter in filters)
                {
                    request.AddParameter(filter.Name, filter.Value);
                }
            }
            if (apiKey != null) request.AddParameter("api-key", apiKey);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject(response.Content);
        }
    }
}