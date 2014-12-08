using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "CSharp_Code_Assesser_WebAPI",
                routeTemplate: "Code_Assesser_WebAPI/{controller}/{title}",
                defaults: new { title = RouteParameter.Optional }
            );

            // renvoyer que du JSON
            //var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            //config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
            var jqueryFormatter = config.Formatters.FirstOrDefault(x => x.GetType() == typeof(JQueryMvcFormUrlEncodedFormatter));
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Remove(config.Formatters.FormUrlEncodedFormatter);
            config.Formatters.Remove(jqueryFormatter);

            // renvoyer du JSON par défaut
            //var jsonFormatter = config.Formatters.JsonFormatter;
            //config.Formatters.Remove(jsonFormatter);
            //config.Formatters.Insert(0, jsonFormatter);
        }
    }
}
