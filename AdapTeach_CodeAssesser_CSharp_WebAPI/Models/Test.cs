using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Data
{
    /// <summary>
    /// Learners submit solutions to assessments. To check if a submission is correct, the assessment's creator writes one or more tests that will be run against the submitted code. If a submission passes all the tests for the assessment, then the solution is considered correct.
    /// </summary>
    public class Test
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      
        
        /// <summary>
        /// a description of the tested feature (typically starts with "Should...")
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// (can be empty) a string holding a piece of code that is executed once for each submission. It can be used to create and assign variables that will be used in the assertions.
        /// </summary>
        public string InitializationCode
        {
            get;
            set;
        }

        /// <summary>
        /// an array (can NOT be empty) of expressions checking that the submitted code has the expected behavior. For a test to pass, all assertions must pass. An assertion can return a boolean (true means that the behavior is correct, false means that the submission fails the test). Alternatively, an assertion can throw an exception if the submitted code has an unexpected behavior. This allows the use of assertion libraries for more readable and expressive assertions.
        /// </summary>
        public string Assertions
        {
            get;
            set;
        }

        ///// <summary>
        ///// Assessment
        ///// </summary>
        //public Assessment Assessment
        //{
        //    get;
        //    set;
        //}

        //-------------------------------------------------------------------------------------------------------------      
        #endregion Properties

        #region Constructor
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// Default constructor
        /// </summary>
        public Test()
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