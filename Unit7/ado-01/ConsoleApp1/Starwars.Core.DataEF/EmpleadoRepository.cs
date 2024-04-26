using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Starwars.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.DataEF
{
    public class EmpleadoRepository
    {
        private readonly StarwarsDBContext _dbContext;

        public EmpleadoRepository(StarwarsDBContext dbContext) {
            _dbContext = dbContext;
        }

        public List<Empleado> ObtenerTodos()
        {
            //var empleados = new List<Empleado>();

            var query = from e in _dbContext.Empleados
                        select e;

            return query.ToList();
        }

        public bool Guardar(Empleado empleado) {

            _dbContext.Empleados.Add(empleado);

            try
            {
                _dbContext.SaveChanges();
            }
            catch (SqlException ex)
            {
                //Logear
                LogDemo(ex.Message);
                return false;
            }
            catch (DbUpdateException ex)
            {
                //Logear
                LogDemo(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                //Logear
                LogDemo(ex.Message);
                return false;
            }
            //finally { 
                
            //}
          

            return true;
        }

        public void LogDemo(string mensaje) {
            return;
        }

        public bool Eliminar(Empleado empleado)
        {
            _dbContext.Empleados.Remove(empleado);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
