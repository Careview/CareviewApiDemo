using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CareviewApi.Helpers
{
    public static class HttpGet
    {
        public static async Task<string> GetContentAsync(HttpClient client, string url)
        {
            var rs = await client.GetAsync(url);
            if (rs.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Error");
            }
            return await rs.Content.ReadAsStringAsync();
        }

        public static async Task<string> PostContentAsync(HttpClient client, string url, object payload)
        {
            var body = JsonConvert.SerializeObject(payload);
            var content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
            
            var rs = await client.PostAsync(url, content);
            if (rs.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(rs.StatusCode.ToString() + ": " + rs.ReasonPhrase);
            }
            return await rs.Content.ReadAsStringAsync();
        }
    }
}
