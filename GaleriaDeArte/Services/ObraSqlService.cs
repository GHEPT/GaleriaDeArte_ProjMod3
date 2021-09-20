using GaleriaDeArte.Data;
using GaleriaDeArte.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GaleriaDeArte.Services
{
    public class ObraSqlService : IObraService
    {
        GaleriaContext _context;

        public ObraSqlService(GaleriaContext context)
        {
            _context = context;
        }

        public List<Obra> GetAll(string busca = null, bool ordenar = false)
        {
            List<Obra> lista = _context.Obra.AsNoTracking().Include(o => o.Lances).ToList();
            if (ordenar)
                lista = lista.OrderBy(o => o.Nome).ToList();

            if (busca != null)
                lista = lista.FindAll(a => a.Nome.ToLower().Contains(busca.ToLower())); 
                
            return lista;
        }

        public Obra Get(int? id)
        {
            return _context.Obra.AsNoTracking().Include(o => o.Lances).FirstOrDefault(o => o.Id == id); // assim eu busco pela chave primaria (só para o id).
        }

        public bool Create(Obra obra)
        {
            try
            {
                _context.Obra.Add(obra);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool Update(Obra obra)
        {
            try
            {
                _context.Obra.Update(obra);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }     
        }

        public bool Delete(int? id)
        {
            try
            {
                var obra = Get(id);
                _context.Obra.Remove(obra);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            

        }
    }
}
