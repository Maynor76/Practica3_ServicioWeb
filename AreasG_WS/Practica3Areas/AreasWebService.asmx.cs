using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica3Areas
{
    /// <summary>
    /// Descripción breve de AreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal Triangulo(decimal Base, decimal Altura)
        {
            Areas r = new Areas();
            return r.Triangulo(Base, Altura);
        }
    }
}
