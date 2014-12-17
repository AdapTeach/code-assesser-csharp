using System;
using System.Web.Http;
using AdapTeach_CSharp_Code_Assesser_WebAPI.Engine;
using AdapTeach_CSharp_Code_Assesser_WebAPI.Models;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Controllers
{
    /// <summary>
    /// Controller qui prends un buffer JSON representant une Submission en entrée envoyée en HTTP POST, le process et le retourne en JSON complété de ses infos d'assessment
    /// </summary>
    public class AssessmentsController : ApiController
    {
        /// <summary>
        /// Web API qui traite une submission
        /// </summary>
        /// <param name="sub">objet JSON passé en HTTP POST déserialisé en objet .net Submission</param>
        /// <returns>reponse http contenant un objet SubmissionResult serialisé en JSON</returns>
        [HttpPost]
        public IHttpActionResult GetAssessment([FromBody] Submission sub)
        {
            try
            {
                if (sub == null)
                {
                    //return NotFound();
                    return InternalServerError(new Exception("Error while deserializing JSON object Submission"));
                }
                return Ok(SubmissionVerifier.ProcessSubmission(sub));
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
