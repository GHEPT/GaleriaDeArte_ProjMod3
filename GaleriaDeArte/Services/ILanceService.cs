using GaleriaDeArte.Models;
using System.Collections.Generic;

namespace GaleriaDeArte.Services
{
    public interface ILanceService
    {
        bool Create(Lance lance, string userName);
        bool Delete(int? id);
        Lance Get(int? id);
        List<Lance> GetAll(string userName);
        bool Update(Lance lance);
    }
}