using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Data
{
    /// <summary>
    /// The code-assessments module send POST requests to the respective code-assesser-[language] modules. For example, when a learner submits a solution for a java assessment, a request is sent to code-assesser-java.
    /// </summary>
    public class Submission
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// the complete assessment for which the submission has been made
        /// </summary>
        public Assessment Assessment
        {
            get;
            set;
        }

        /// <summary>
        /// the same compilation units found in the compilationUnitsToSubmit array, most probably modified by the learner in his attempt to submit a correct solution
        /// </summary>
        public IEnumerable<CompilationUnit> SubmittedCompilationUnits
        {
            get;
            set;
        }

        //-------------------------------------------------------------------------------------------------------------      
        #endregion Properties

        #region Constructor
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// Default constructor
        /// </summary>
        public Submission()
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