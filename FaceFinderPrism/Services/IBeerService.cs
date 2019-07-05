using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FaceFinderPrism.ViewModels
{
    public interface IBeerService
    {
       Task<IEnumerable<Beer>> GetAllTheBeersAsync();
    }
}