using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace practica3
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public string circulo(double radio)
        {
            var resultado = radio * radio * 3.14;
            return resultado.ToString();

        }

        [WebMethod]
        public string cuadrado(int lado)
        {
            var resultado = lado * lado;
            return resultado.ToString();
        }


        [WebMethod]
        public string triangulo(int bases, int altura)
        {
            var resultado = (bases * altura) / 2;
            return resultado.ToString();
            
            }
    }
}
