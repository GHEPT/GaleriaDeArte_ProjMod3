using GaleriaDeArte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaleriaDeArte.Services
{
    public class ObraFullService : IObraService
    {
        IObraService _serviceStatic, _serviceSql;
        public ObraFullService(ObraStaticService serviceStatic, ObraSqlService serviceSql)
        {
            _serviceStatic = serviceStatic;
            _serviceSql = serviceSql;
        }
        public List<Obra> GetAll(string busca, bool ordenar)
        {
            List<Obra> obrasSql = _serviceSql.GetAll(busca, ordenar);
            List<Obra> obrasStatic = _serviceStatic.GetAll(busca, ordenar);

            List<Obra> lista = obrasStatic.Concat(obrasSql).ToList();

            if (ordenar)
                lista = lista.OrderBy(o => o.Nome).ToList();

            if (busca != null)
                lista = lista.FindAll(a => a.Nome.ToLower().Contains(busca.ToLower()));

            return lista;

        }
        public bool Create(Obra obra)
        {
            return false;
        }

        public bool Delete(int? id)
        {
            return false;
        }

        public Obra Get(int? id)
        {
            return new();
        }

        public bool Update(Obra obra)
        {
            return false;
        }
    }
}
