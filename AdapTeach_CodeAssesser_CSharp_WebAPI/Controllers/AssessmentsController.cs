using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdapTeach_CSharp_Code_Assesser_WebAPI.Data;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Controllers
{
    /// <summary>
    /// Controller qui prends un buffer JSON representant un Assessment en entrée, le process et le retourne en JSON complété de ses infos d'assessment
    /// </summary>
    public class AssessmentsController : ApiController
    {
        /// <summary>
        /// Fait passer la validation de l'assessment
        /// </summary>
        /// <param name="ass"></param>
        private static Assessment ProcessAssessment(Assessment ass)
        {
            Assessment toReturn = null;
            return toReturn;
        }

        /// <summary>
        /// NotImplemented
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Assessment> GetAllAssessments()
        {
            return null;
        }

        /// <summary>
        /// Web API qui fait passer un assessment
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public IHttpActionResult GetAssessment(Assessment ass)
        {
            if (ass == null)
            {
                return NotFound();
            }
            return Ok(AssessmentsController.ProcessAssessment(ass));
        }
    }
}
