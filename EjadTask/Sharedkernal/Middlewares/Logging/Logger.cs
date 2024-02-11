using Serilog;
using System.Text.Json;

namespace EjadTask.Sharedkernal.Middlewares.Logging
{
    public class Logger:ILogger
    {
        public void Debug(string message)
        {
            Log.Debug(message);
        }

        public void Debug(string message, object data)
        {
            Log.Logger.Data(data).Debug(message);
        }

        public void Error(System.Exception exception)
        {
            Log.Error(exception, exception.Message);
        }

        public void Error(System.Exception exception, object data)
        {
            Log.Logger.Data(data).Error(exception, exception.Message);
        }

        public void Error(string message)
        {
            Log.Error(message);
        }

        public void Error(string message, object data)
        {
            Log.Logger.Data(data).Error(message);
        }

        public void Fatal(System.Exception exception)
        {
            Log.Fatal(exception, exception.Message);
        }

        public void Fatal(System.Exception exception, object data)
        {
            Log.Logger.Data(data).Fatal(exception, exception.Message);
        }

        public void Information(string message)
        {
            Log.Information(message);
        }

        public void Information(string message, object data)
        {
            Log.Logger.Data(data).Information(message);
        }

        public void Warning(string message)
        {
            Log.Warning(message);
        }

        public void Warning(string message, object data)
        {
            Log.Logger.Data(data).Warning(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <param name="body"></param>
        public void IntegrationRequestAndResponsDeatails(HttpResponseMessage response, string body)
        {
            var log = new
            {
                Url = response.RequestMessage.RequestUri,
                Headers = JsonSerializer.Serialize(response.Headers.ToDictionary(h => h.Key, h => h.Value)),
                Body = body,
                Method = response.RequestMessage.Method,
                StatusCode = response.StatusCode,
                ReasonPhrase = response.ReasonPhrase,
                Response = response.Content.ReadAsStringAsync(),
                RequestDate = DateTime.UtcNow
            };
            Log.Information(JsonSerializer.Serialize(log));
        }
    }
}

    

