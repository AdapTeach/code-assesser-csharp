using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class Submission
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// Assessment
        /// </summary>
        public Assessment Assessment
        {
            get;
            set;
        }

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