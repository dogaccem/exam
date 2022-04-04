using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ExamSystem.Services.Extensions
{
    public static class SessionObjectExtension
    {
        public static T GetObject<T>(this ISession session, string key)
        {
            string jsonString = session.GetString(key);

            if (string.IsNullOrEmpty(jsonString))
            {
                return default(T);
            }

            var result = JsonSerializer.Deserialize<T>(jsonString);

            return result;
        }

        public static void SetObject<T>(this ISession session, string key, T value)
        {
            string jsonString = JsonSerializer.Serialize<T>(value);

            session.SetString(key, jsonString);
        }
    }
}
