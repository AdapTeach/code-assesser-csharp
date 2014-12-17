using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using AdapTeach_CSharp_Code_Assesser_WebAPI.App_Start;

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

            //Only JSON
            config.Formatters.Clear();
            var jsonFormatter = new JsonMediaTypeFormatter();
            config.Formatters.Add(jsonFormatter);
            //skip content negociation, we support JSON Only
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));
        }
    }
}
