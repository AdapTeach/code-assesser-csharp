using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using AdapTeach_CSharp_Code_Assesser_WebAPI.Models;
using Microsoft.CSharp;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Controllers
{
    /// <summary>
    /// Controller qui prends un buffer JSON representant une Submission en entrée envoyée en HTTP POST, le process et le retourne en JSON complété de ses infos d'assessment
    /// </summary>
    public class AssessmentsController : ApiController
    {

        private static CompilerResults CompileCode(CompilationUnit cu)
        {
            CodeDomProvider cpd = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();
            cp.ReferencedAssemblies.Add("System.dll");
            //cp.ReferencedAssemblies.Add("ClassLibrary1.dll");
            cp.GenerateExecutable = false;
            cp.GenerateInMemory = true;
            // Set the assembly file name to generate.
            cp.OutputAssembly = cu.Name;
            // Invoke compilation.
            return cpd.CompileAssemblyFromSource(cp, cu.Code);
        }

        private static SubmissionResult GetErrors(CompilerResults cr)
        {
            var pass = false;
            var errors = new List<string>();
            SubmissionResult toReturn = new SubmissionResult { Pass = pass, CompilationErrors = errors, FailedTestMessage = new List<string>() };

            if (cr.Errors != null)
            {
                if (cr.Errors.HasWarnings)
                { pass = true; }
                if (cr.Errors.HasErrors)
                { pass = false; }
                foreach (CompilerError error in cr.Errors)
                {
                    errors.Add(error.ErrorText);
                }
            }
            else
            {
                Assembly dll = cr.CompiledAssembly;
            }
            return toReturn;
        }

        /// <summary>
        /// Parse le code c# 
        /// </summary>
        /// <param name="cu"></param>
        /// <returns></returns>
        private static SubmissionResult CheckCompilationUnit(CompilationUnit cu)
        {
            return GetErrors(CompileCode(cu));
        }

        /// <summary>
        /// Compile le code c# 
        /// </summary>
        /// <param name="cu"></param>
        /// <returns></returns>
        private static bool CompileCompilationUnit(CompilationUnit cu)
        {
            return false;
        }


        /// <summary>
        /// Fait passer la validation de la submission
        /// </summary>
        /// <param name="sub">submission request deserialized</param>
        private static SubmissionResult ProcessSubmission(Submission sub)
        {
            SubmissionResult toReturn = null;

            var currentAss = sub.Assessment;

            foreach (var cu in sub.SubmittedCompilationUnits)
            {
                toReturn = CheckCompilationUnit(cu);
            }


            return toReturn;
        }

        /// <summary>
        /// Web API qui traite une submission
        /// </summary>
        /// <param name="sub">objet JSON passé en HTTP POST déserialisé en objet .net Submission</param>
        /// <returns>reponse http contenant un objet SubmissionResult serialisé en JSON</returns>
        [HttpPost]
        public IHttpActionResult GetAssessment(Submission sub)
        {
            try
            {
                if (sub == null)
                {
                    //return NotFound();
                    return InternalServerError(new ArgumentNullException("Submission", "Error while deserializing JSON object Submission"));
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
