using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assesser_WebAPI.Data
{
    public class Test
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      
        
        /// <summary>
        /// Title is required
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// code is required
        /// </summary>
        public string InitializationCode
        {
            get;
            set;
        }

        /// <summary>
        /// expectations are required
        /// </summary>
        public string Expectations
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