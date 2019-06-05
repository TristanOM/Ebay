using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Ebay_API2.EbayApi
{
    public static class Ebay_API
    {
      
        public static void TestAPI()
        {

        }

        public static async Task<string> SandBoxBrowse()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer v^1.1#i^1#I^3#r^0#p^1#f^0#t^H4sIAAAAAAAAAOVYa2wUVRTu9qU8qsYQUTFhMyI+6Mzemd3uY2xXtg/SJZQubqk8SuvdmTvt0NmZydw7djfEUBqDr/CK0QRDTKXww4IJBEEhkZCof4ygEaJGjRhFrPwykYcaEr0zu5RtJdCWok3cP5N777nnfuc735l7dkBv+bTHNjZuvFThua24vxf0Fns8/AwwrbxswR0lxfeXFYECA09/77ze0r6SoWoM05opPomwaegYeTNpTceiO1nD2JYuGhCrWNRhGmGRSGIy1rREFDggmpZBDMnQGG+8voaRoAxBhA+FIpICA4JAZ/UrPluMGkYAoQBSYCoEIAr5gym6jrGN4jomUCfOOh9hQZAFgRaBFwVB5INcxB9exXhbkYVVQ6cmHGCiLlzR3WsVYL0+VIgxsgh1wkTjsUXJ5li8vmFpS7WvwFc0z0OSQGLjkaM6Q0beVqjZ6PrHYNdaTNqShDBmfNHcCSOdirErYCYA36U6FFCUgAIBhJFAGMj8pFC5yLDSkFwfhzOjyqzimopIJyrJ3ohRykZqLZJIfrSUuojXe53HMhtqqqIiq4ZpqI2tjCUSTLTFUp0gmtkWOmSTtSvYiJxShGAwJbOASkdRFH/+kJynPMWjTqkzdFl1CMPepQapRRQxGs0LX8ALNWrWm62YQhw0hXb+K/wJVauchOYyaJMu3ckpSlMSvO7wxuwP7ybEUlM2QcMeRi+49NQw0DRVmRm96OowL50MrmG6CDFFn6+np4fr8XOG1ekTAOB9K5qWJKUulIZM3tap9QxWb7yBVd1QJER3YlUkWZNiyVCdUgB6JxP1C2EehPK8j4QVHT37j4mCmH0jq2GyqiOC/CgsKf6wXwrACACTUR3RvEB9Dg6Uglk2Da1uREwNSoiVqM7sNLJUWfRXKYI/rCBWDkYUNhBRFDZVJQdZXkEIIJRKSZHw/6VIxirzpGSYKGFoqpSdNLFPjtAtOQEtkq21s3ScRJpGH2PV/TVDxU6o/0KQTq2PI1DHB6ZOoKlyjro5yUj7DEhfa85Uh4vaOxYjX8rOcp02woQikemtMuZNKpUIR4tEHvuWXAnSAMa+hbYssi2RCR3k1jpHmVQ7uwge15mZCZCCqdw4zeikpa5KmDNt2bgp6cVMM55O2wSmNBSfvFvlP7hRrhmeSvutKRUTzWkuuaqca5Q4N8McfkbiLIQN26I9Itfs9A4tRjfS6duYWIamIauVHxcTTq1fK9lTLMfjuLQmpoDJ7Zamiq4lTaXy6Zhqkd3ybKqQTK2I+aqqSDDs9/uDNxVXnZvPluzE2oDSDR/cuggbDUyQfAv6et/ILwzRIvfH93neB32ew8UeD1UMyy8Aj5aXLC8tmclg2gxwGOpyyshwKlQ4euXq9A+0hbhulDWhahWXe9SvT0m/F3zb6F8D7h3+ujGthJ9R8KkDPHB1pYy/c3YFHwFBEBB4QeCDq8CDV1dL+XtKZ7UdXznnw9bHLwaatz+k2MuWlwiBflAxbOTxlBWV9nmKZlYObvs+NHfLgvXV4M9Nu97MnPx59bLG2WLftq1D51tPbJYXb6vk9+8u76448vSlwYafgk8tXrc5/MOLQ58/3PbyC5f/+MysX6g0Coc79v+oHty/3Xt87rNvtc/Y1PPaK8yx3d958et72uavVS5U7jm4i3vv8hOVC+8ObSLrmzbI8+DpwQMdZ078tmOHL7H30HOfTuf2da1ue746882hUzs3ehKNp9seWVO5tan32OCvs+47kp1eXnJuZ9HAvrNzfJ/MGXgn9dXtB/rfZj9uP+f5As+8WNXw19YBsu7oR/gXJnNhz5che2jD/ItNxUdfere97jzzatvZk9Zdb3ybjeztSpwcmK61z10ycMa3I5RL498lBsIndRIAAA==");
                    client.DefaultRequestHeaders.Add("X-EBAY-C-ENDUSERCTX", "contextualLocation=country=<2_character_country_code>,zip=<zip_code>,affiliateCampaignId=<ePNCampaignId>,affiliateReferenceId=<referenceId>");
                    
                    HttpResponseMessage response = await client.GetAsync("https://api.sandbox.ebay.com/buy/browse/v1/item/2");
                    //response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                    return "";
                }
            }
        }

        public static async Task<HttpResponseMessage> TestKeyValues()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.mywebsite.com");
            var request = new HttpRequestMessage(HttpMethod.Get, "oauth/api_scope");

            var keyValues = new List<KeyValuePair<string, string>>();
            keyValues.Add(new KeyValuePair<string, string>("site", "https://api.ebay.com"));
            keyValues.Add(new KeyValuePair<string, string>("content", "This is some content"));

            request.Content = new FormUrlEncodedContent(keyValues);
            var response = await client.SendAsync(request);
            return response;
        }

    }
}