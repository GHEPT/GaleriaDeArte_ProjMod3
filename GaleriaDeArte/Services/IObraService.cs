using GaleriaDeArte.Models;
using System.Collections.Generic;

namespace GaleriaDeArte.Services
{
    public interface IObraService
    {
        bool Create(Obra obra);
        bool Delete(int? id);
        Obra Get(int? id);
        List<Obra> GetAll(string busca, bool ordenar);
        bool Update(Obra obra);
    }
}