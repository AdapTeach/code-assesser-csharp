using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Models
{
    /// <summary>
    /// Compilation Unit represents a single unit of code, and its form can vary greatly depending on the programming language. For example, in Java a compilation unit can be a class, an interface or an enum
    /// </summary>
    public class CompilationUnit
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// the name (equivalent to the file name, without the .java extension)
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// the code (equivalent to the file content)
        /// </summary>
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// can be one of class, interface or enum
        /// </summary>
        public Type Kind
        {
            get;
            set;
        }

        ///// <summary>
        ///// a CompilationUnit must belong to a user
        ///// </summary>
        //public string Creator
        //{
        //    get;
        //    set;
        //}

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