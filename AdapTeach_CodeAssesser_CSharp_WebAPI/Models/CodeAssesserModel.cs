using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdapTeach_CSharp_Code_Assessment_WebAPI.Data;

namespace AdapTeach_CSharp_Code_Assessment_WebAPI.Models
{
    /// <summary>
    /// Model
    /// </summary>
    public class CodeAssesserModel
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// Submission
        /// </summary>
        public Submission Submission
        {
            get;
            set;
        }

        /// <summary>
        /// Assessment
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
        public CodeAssesserModel()
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