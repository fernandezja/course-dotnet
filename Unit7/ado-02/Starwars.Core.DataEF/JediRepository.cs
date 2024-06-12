using Microsoft.EntityFrameworkCore;
using Starwars.Core.Entities;
using Starwars.Core.Entities.Filters;

namespace Starwars.Core.DataEF
{
    public class JediRepository
    {

        public JediRepository()
        {

        }

        public JediResult GetAll()
        {

            var result = new JediResult();

            using (var db = new StarwarsContext())
            {

                result.Items = db.Jedis.ToList();
            }

            return result;

        }

        public async Task<JediResult> SearchAsync(JediFilter filter)
        {

            var result = new JediResult();

            using (var db = new StarwarsContext())
            {
                var skip = (filter.PageIndex - 1) * filter.PageSize;

                result.Items = await db.Jedis
                                    .Skip(skip)
                                    .Take(filter.PageSize)
                                    .ToListAsync();
                }

            return result;

        }




        public GenericResult DeleteAsync(int jediId)
        {
            var result = new GenericResult();

            using (var db = new StarwarsContext())
            {
                var jedi = from j in db.Jedis
                           where j.JediId == jediId
                           select j;

                var entityEntry = db.Jedis.Remove(jedi.FirstOrDefault());


                db.SaveChanges();

            }

            result.IsSuccessful = true;

            return result;
        }



        public Jedi GetAsync(int jediId)
        {

            using (var db = new StarwarsContext())
            {
                var jedi = from j in db.Jedis
                           where j.JediId == jediId
                           select j;

                return jedi.FirstOrDefault();

            }
        }


        public GenericResult UpdateAsync(Jedi jedi)
        {

            using (var db = new StarwarsContext())
            {
                db.Attach(jedi);

                //db.Entry(jedi).Property(jedi => jedi.Name).IsModified = true;
                db.Entry(jedi).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                db.SaveChanges();
            }

            var result = new GenericResult();
            result.IsSuccessful = true;

            return result;
        }
    }
}
