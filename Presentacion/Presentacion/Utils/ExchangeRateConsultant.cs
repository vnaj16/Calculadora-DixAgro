using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Presentacion.Utils
{
    public static class ExchangeRateConsultant
    {
        public static double GetExchangeRateSolesToDollar()
        {
            try
            {
                HttpClient client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(@"https://api.cambio.today/v1/quotes/EUR/USD/json?quantity=1&key=11376|~S4pNw_xo6aZJt82NS71hAvo2bF*dazs").Result;
                if (response.IsSuccessStatusCode)
                {
                    string content = response.Content.ReadAsStringAsync().Result;
                    //Items = JsonSerializer.Deserialize<List<TodoItem>>(content, serializerOptions);
                }

                Random r = new Random();
                if (r.Next(0,5) % 2 == 0)
                {
                    throw new Exception();
                }
                return 6.14;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener el tipo de cambio. Por favor, ingresar el tipo de cambio manualmente"); ;
            }

        }
    }
}

/*RESPONSE JSON EXCHANGE RATE
 {
  "result": {
    "updated": "2020-11-27T22:29:51",
    "source": "EUR",
    "target": "USD",
    "value": 1.19703,
    "quantity": 1.0,
    "amount": 1.19703
  },
  "status": "OK"
}
 */