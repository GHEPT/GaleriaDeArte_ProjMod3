using GaleriaDeArte.Data;
using GaleriaDeArte.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GaleriaDeArte.Services
{
    public class LanceSqlService : ILanceService
    {
        GaleriaContext _context;

        public LanceSqlService(GaleriaContext context)
        {
            _context = context;
        }

        public List<Lance> GetAll(string userName)
        {
            string userId = _context.Users.FirstOrDefault(u => u.UserName == userName).Id;
            return _context.Lance
                .Where(a => a.UserId == userId)
                .AsNoTracking().Include(o => o.Obra).ToList();
            //return _context.Lance.AsNoTracking().Include(o => o.Obra).ToList(); // Vou trazer também as obras  
        }

        public Lance Get(int? id)
        {
            try
            {
                Lance l = _context.Lance.AsNoTracking().Include(o => o.Obra).FirstOrDefault(o => o.Id == id);// assim eu busco pela chave primaria (só para o id).
                if (l == null) throw new Exception("Lance não existe");
                else return l;
            }
            catch
            {
                throw new Exception("Obra não existe");
            }  
        }

        public bool Create(Lance lance, string userName)
        {
            string userId = _context.Users.FirstOrDefault(u => u.UserName == userName).Id;
            lance.UserId = userId;
            lance.Obra = _context.Obra.Find(lance.ObraId);
            try
            {
                _context.Lance.Add(lance);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Update(Lance lance)
        {
            try
            {
                _context.Lance.Update(lance);
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
                var lance = Get(id);
                _context.Lance.Remove(lance);
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
