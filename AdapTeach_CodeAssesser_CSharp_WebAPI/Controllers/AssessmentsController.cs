using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdapTeach_CSharp_Code_Assesser_WebAPI.Models;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Controllers
{
    /// <summary>
    /// Controller qui prends un buffer JSON representant une Submission en entrée envoyée en HTTP POST, le process et le retourne en JSON complété de ses infos d'assessment
    /// </summary>
    public class AssessmentsController : ApiController
    {
        /// <summary>
        /// Fait passer la validation de la submission
        /// </summary>
        /// <param name="ass"></param>
        private static SubmissionResult ProcessSubmission(Submission sub)
        {
            SubmissionResult toReturn = null;
            return toReturn;
        }

        /// <summary>
        /// Web API qui traite une submission
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GetAssessment([FromBody] Submission sub)
        {
            try
            {
                if (sub == null)
                {
                    return NotFound();
                }
                return Ok(AssessmentsController.ProcessSubmission(sub));
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
