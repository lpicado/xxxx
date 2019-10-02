using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xxxx.dal;

namespace xxxx.bl
{
    public class Prueba
    {

        public void Prueba1()
        {
            Vuelos vl = new Vuelos();
            vl.Duracion = 5;
            vl.Escala = "XXX";

            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                //var vuelos = Context.Vuelos.ToList();

                context.Vuelos.Add(vl);
                context.SaveChanges();

            }

        }

        public void PruebaSelect()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                var vuelos = context.Vuelos.ToList();
            }
        }
        public void PruebaSelect2()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    var vuelos = context.Vuelos.Where(x => x.Id_vuelo == 4).SingleOrDefault();
                }
                catch (Exception ep)
                {
                    Console.WriteLine("Error: " + ep.Message);
                }

            }
        }
        public void PruebaSelect3()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    var vuelos = context.Vuelos.Where(x => x.Id_vuelo == 4).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " +  ex.Message);
                }

            }
        }
    }
}
