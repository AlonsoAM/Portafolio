using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto()
                {
                    Titulo = "SISPACKING",
                    Decripcion = "Proyecto Web realizado en ASP.NET Framework",
                    Link =  "http://sispacking.azurewebsites.net/",
                    ImagenURL = "/imagenes/sispacking2.png"
                },
                new Proyecto()
                {
                    Titulo = "SISPACKING",
                    Decripcion = "Proyecto Web realizado en ASP.NET Framework",
                    Link =  "http://sispacking.azurewebsites.net/",
                    ImagenURL = "/imagenes/SISPACKING.png"
                },
                new Proyecto()
                {
                    Titulo = "SISPACKING",
                    Decripcion = "Proyecto Web realizado en ASP.NET Framework",
                    Link =  "http://sispacking.azurewebsites.net/",
                    ImagenURL = "/imagenes/SISPACKING.png"
                }
            };
        }
    }
}
