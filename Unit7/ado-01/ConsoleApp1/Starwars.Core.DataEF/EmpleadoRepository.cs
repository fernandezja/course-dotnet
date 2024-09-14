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
        //private readonly StarwarsDBContext _dbContext;

        public EmpleadoRepository() {
           // _dbContext = dbContext;
        }

        public List<Empleado> ObtenerTodos()
        {
            //var empleados = new List<Empleado>();

            using (var dbContext = new StarwarsDBContext())
            {
                //var query1 = _dbContext.Empleados.ToList();

                var query = from e in dbContext.Empleados
                            select e;

                return query.ToList();
            }

            
        }


        public List<Empleado> ObtenerTodos(EmpleadoFiltro filtro)
        {

            using (var dbContext = new StarwarsDBContext())
            {
                //var query1 = _dbContext.Empleados.ToList();

                var query = from e in dbContext.Empleados
                            where e.Nombre.Contains(filtro.TextoABuscar)
                            select e;

                var skip = (filtro.PageIndex - 1) * filtro.PageSize;

                return query.Skip(skip)
                            .Take(filtro.PageSize)
                            .ToList();
            }


        }

        public bool Guardar(Empleado empleado) {

            var dbContext = new StarwarsDBContext();

            dbContext.Empleados.Add(empleado);

            try
            {
                dbContext.SaveChanges();
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
            var dbContext = new StarwarsDBContext();
            dbContext.Empleados.Remove(empleado);
            dbContext.SaveChanges();

            return true;
        }
    }
}
