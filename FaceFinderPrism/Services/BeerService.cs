using FaceFinderPrism.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace FaceFinderPrism.Services
{
    public class BeerService : IBeerService
    {
        //OjO This method ASYNCRONOU 
        public async Task<IEnumerable<Beer>> GetAllTheBeersAsync()
        {
            var giveMeAllTheBeers = new List<Beer>();
            try
            {
                //This Variable for save a list
               
                //this using is for make a instance of The class HTTPClient(), this use for get a protocol
                using (var protocol = new HttpClient())
                {
                    //we use this variable for to convert the API Rest USING A METHOD <GetStringAsync>
                    var stringOfApi = await protocol.GetStringAsync("https://api.punkapi.com/v2/beers");
                
                    //Return the obj Deserialized
                   return giveMeAllTheBeers = JsonConvert.DeserializeObject<List<Beer>>(stringOfApi);
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception: {ex}");
            }

            return giveMeAllTheBeers;
        }


    }
       
    }
