using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Models
{
    /// <summary>
    /// Assessment represents a single coding challenge to be tackled by a learner.
    /// </summary>
    public class Assessment
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// the id of the assessment resource provided by the code-assessments project
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// a short descriptive name for the assessment
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// the programming language of the assessment and it's solution (can be java, csharp...)
        /// </summary>
        public string Language
        {
            get;
            set;
        }

        ///// <summary>
        ///// Creator
        ///// </summary>
        //public string Creator
        //{
        //    get;
        //    set;
        //}

        /// <summary>
        /// a textual description of the solution the learner is expected to submit
        /// </summary>
        public string Instructions
        {
            get;
            set;
        }

        ///// <summary>
        ///// Liste de guides
        ///// </summary>
        //public IEnumerable<Guide> Guides
        //{
        //    get;
        //    set;
        //}

        /// <summary>
        /// an array (can NOT be empty) of tests
        /// </summary>
        public IEnumerable<Test> Tests
        {
            get;
            set;
        }

        /// <summary>
        /// an array (can be empty) of compilation units which are part of the assessment, but that the learner cannot edit
        /// </summary>
        public IEnumerable<CompilationUnit> ProvidedCompilationUnits
        {
            get;
            set;
        }

        /// <summary>
        /// an array (can NOT be empty) of compilation units which the learner is able to edit. Typically, these are the compilation units that the learer is expected to modify in order to submit the correct solution.
        /// </summary>
        public IEnumerable<CompilationUnit> CompilationUnitsToSubmit
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
        public Assessment()
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