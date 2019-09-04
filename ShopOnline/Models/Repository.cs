using System;
using System.Collections.Generic;

namespace ShopOnline.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponce(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
