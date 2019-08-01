
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EricCupueran_ExamenVueling
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private static List<String> listaRebelde = new List<string>();
        private static List<String> listaSoldado = new List<string>();

        [WebMethod]
        public bool AddListServiceRebelde(String rebelde, string planeta)
        {
            try {
                listaRebelde.Add(rebelde+"," + planeta);
                return true;
            } catch { return false; }
        }

        [WebMethod]
        public List<string> GetRebeldesService()
        {
            return listaRebelde;
        }

        [WebMethod]
        public bool AddListServiceSoldado(string soldado, string planeta)
        {
            try
            {
                listaSoldado.Add(soldado + "," + planeta);
                return true;
            }
            catch { return false; }
        }

        [WebMethod]
        public List<string> GetSoldadosService()
        {
            return listaSoldado;
        }
    }
}
