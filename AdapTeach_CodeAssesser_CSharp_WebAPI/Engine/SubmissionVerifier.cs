using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using AdapTeach_CSharp_Code_Assesser_WebAPI.Models;
using Microsoft.CSharp;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Engine
{
    public static class SubmissionVerifier
    {
        private const string SPACE = " ";
        private const string LEFT_PARENTHESIS = "(";
        private const string RIGHT_PARENTHESIS = "): ";
        private const string LINE = "Line: ";
        private const string COLUMN = ", Column: ";

        private static CompilerResults CompileCode(CompilationUnit cu)
        {
            CodeDomProvider cpd = new CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters();
            //cp.ReferencedAssemblies.Add("System.dll");
            //cp.ReferencedAssemblies.Add("ClassLibrary1.dll");
            cp.GenerateExecutable = false;
            cp.GenerateInMemory = true;
            // Set the assembly file name to generate.
            cp.OutputAssembly = cu.Name;
            // Invoke compilation.
            return cpd.CompileAssemblyFromSource(cp, cu.Code);
        }

        /// <summary>
        /// Return a list of compilation errors (including warnings) from a <see cref="CompilerResults"/>
        /// </summary>
        /// <param name="cr">compilation results</param>
        /// <returns>list of compilation errors and warnings</returns>
        private static List<string> GetErrors(CompilerResults cr)
        {
            var errors = new List<string>();
            foreach (CompilerError error in cr.Errors)
            {
                errors.Add(LEFT_PARENTHESIS + LINE + error.Line + COLUMN + error.Column + RIGHT_PARENTHESIS + error.ErrorText);
            }
            return errors;
        }

        /// <summary>
        /// Fait passer la validation de la submission
        /// </summary>
        /// <param name="sub">submission request deserialized</param>
        public static SubmissionResult ProcessSubmission(Submission sub)
        {
            SubmissionResult toReturn = new SubmissionResult();

            try
            {
                var currentAss = sub.Assessment;
                //var compiledUnits = new List<CompilerResults>();

                var totalErrors = new List<string>();
                var pass = true;
                
                foreach (var cu in sub.SubmittedCompilationUnits)
                {
                    var compilationResult = CompileCode(cu);
                    //compiledUnits.Add(compilationResult);
                    if (compilationResult.Errors != null)
                    {
                        totalErrors.AddRange(GetErrors(compilationResult));
                        if (compilationResult.Errors.HasErrors)
                        {
                            pass = false;
                            toReturn.CompilationErrors = totalErrors;
                            break;
                        }
                    }
                }

                toReturn.Pass = pass;
            }
            catch (Exception e)
            {
                toReturn.Pass = false;
                toReturn.ExceptionMessage = e.Message;
            }

            return toReturn;
        }
    }
}