using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assessment_WebAPI.Models
{
    /// <summary>
    /// The code-assesser-[language] modules are expected to respond to POST requests in a standardized way.
    /// </summary>
    public class SubmissionResult
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// a boolean informing if the submission was correct (passed all tests) or not
        /// </summary>
        public bool Pass
        {
            get;
            set;
        }

        /// <summary>
        /// an array of Strings listing all compilation errors, if any
        /// </summary>
        public IEnumerable<string> CompilationErrors
        {
            get;
            set;
        }

        /// <summary>
        /// the message any eventual exception throw by the submitted code, if any
        /// </summary>
        public string ExceptionMessage
        {
            get;
            set;
        }

        /// <summary>
        /// an array consisting of the failed test titles at least, or possibly richer messages (if assertion libraries are used)
        /// </summary>
        public IEnumerable<string> FailedTestMessage
        {
            get;
            set;
        }
        
        
        //-------------------------------------------------------------------------------------------------------------      
        #endregion Properties

        #region Constructor
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SubmissionResult()
        {

        }

        //-------------------------------------------------------------------------------------------------------------      
        #endregion Constructor

        #region Private Methods
        //-------------------------------------------------------------------------------------------------------------      
        //-------------------------------------------------------------------------------------------------------------      
        #endregion Private Methods

        #region Public Methods
        //-------------------------------------------------------------------------------------------------------------      
        //-------------------------------------------------------------------------------------------------------------      
        #endregion Public Methods
        
    }
}