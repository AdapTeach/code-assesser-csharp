using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdapTeach_CSharp_Code_Assessment_WebAPI.Data
{
    /// <summary>
    /// Classe validation d'un exercice
    /// </summary>
    public class Assessment
    {
        #region Properties
        //-------------------------------------------------------------------------------------------------------------      

        /// <summary>
        /// Title unique
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Creator
        /// </summary>
        public string Creator
        {
            get;
            set;
        }

        /// <summary>
        /// Instructions
        /// </summary>
        public string Instructions
        {
            get;
            set;
        }

        /// <summary>
        /// Liste de guides
        /// </summary>
        public IEnumerable<Guide> Guides
        {
            get;
            set;
        }

        /// <summary>
        /// Liste de tests
        /// </summary>
        public IEnumerable<Test> Tests
        {
            get;
            set;
        }

        /// <summary>
        /// Unités de compilation fournies
        /// </summary>
        public IEnumerable<CompilationUnit> ProvidedCompilationUnits
        {
            get;
            set;
        }

        /// <summary>
        /// Unités de compilation à envoyer
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