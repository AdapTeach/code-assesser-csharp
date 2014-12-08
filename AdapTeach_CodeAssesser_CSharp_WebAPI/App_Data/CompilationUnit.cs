using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assessment_WebAPI.Data
{
    public class CompilationUnit
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// Name is required
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Code is required
        /// </summary>
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// type is required
        /// </summary>
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// a CompilationUnit must belong to a user
        /// </summary>
        public string Creator
        {
            get;
            set;
        }

        /// <summary>
        /// a CompilationUnit must belong to an assessment
        /// </summary>
        public Assessment Assessment
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
        public CompilationUnit()
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