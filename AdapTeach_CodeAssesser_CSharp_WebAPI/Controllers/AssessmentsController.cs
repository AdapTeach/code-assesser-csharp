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
    /// 
    /// </summary>
    public class AssessmentsController : ApiController
    {
        private Assessment[] assessments = new Assessment[] 
        { 
            new Assessment { Title = "Title1" }, 
            new Assessment { Title = "Title2" }, 
            new Assessment { Title = "Title3" }
        };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Assessment> GetAllAssessments()
        {
            return this.assessments;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public IHttpActionResult GetAssessment(string title)
        {
            var assessment = this.assessments.FirstOrDefault(ass => ass.Title == title);
            if (assessment == null)
            {
                return NotFound();
            }
            return Ok(assessment);
        }
    }
}
