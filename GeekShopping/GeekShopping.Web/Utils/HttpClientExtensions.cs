﻿using System.Net.Http.Headers;
using System.Text.Json;

namespace GeekShopping.Web.Utils
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue contentType = new MediaTypeHeaderValue("application/json");

        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response) 
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Alguma deu errado na chamada a API: {response.ReasonPhrase}");
            }

            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public static Task<HttpResponseMessage> PostAsJson<T>(this HttpClient httpClient,string url,
            T Data)
        {
            var dataAsString = JsonSerializer.Serialize(Data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJson<T>(this HttpClient httpClient, string url,
            T Data)
        {
            var dataAsString = JsonSerializer.Serialize(Data);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = contentType;
            return httpClient.PutAsync(url, content);
        }

    }
}
