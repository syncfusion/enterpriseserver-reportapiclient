namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Xml.Serialization;    

    /// <summary>
    /// Set the type of credentials to secure data
    /// Prompt: Credentials should be supplied by the user while running the report,
    /// Store: Credentials that stored securely in the report server,
    /// Integrated: Use the Windows credentials of the current user to access the data source,
    /// None: Credentials are not required.
    /// </summary>
    public enum CredentialRetrieval
    {
        Prompt,
        Store,
        Integrated,
        None,
    }

    #region property used in api
    /// <summary>
    /// Select the server type to make datasource connection
    /// </summary>
    public enum ServerType
    {
        None,
        SQL,
        SQLCE,
        OLEDB,
        ODBC,
        Oracle,
        XML,
        SSAS,
        OData,
        PostgreSQL
    }
    #endregion

    /// <summary>
    /// Datasource definition
    /// </summary>
    [Serializable]
    public class DataSourceDefinition
    {
        private string connectStringField;
        private CredentialRetrieval credentialRetrievalField;
        private bool enabledField;
        private bool enabledFieldSpecified;
        private string extensionField;
        private bool impersonateUserField;
        private bool impersonateUserFieldSpecified;
        private bool originalConnectStringExpressionBasedField;
        private string passwordField;
        private string promptField;
        private bool useOriginalConnectStringField;
        private string userNameField;
        private bool windowsCredentialsField;
        private bool windowsCredentialsFieldSpecified;

        /// <summary>
        /// Datasource connection string
        /// </summary>
        public string ConnectString
        {
            get
            {
                return this.connectStringField;
            }

            set
            {
                this.connectStringField = value;
            }
        }

        /// <summary>
        /// Set the type of credentials to secure data
        /// </summary>
        public CredentialRetrieval CredentialRetrieval
        {
            get
            {
                return this.credentialRetrievalField;
            }

            set
            {
                this.credentialRetrievalField = value;
            }
        }

        /// <summary>
        /// Set true if modifying the datasource connection details
        /// </summary>
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }

            set
            {
                this.enabledField = Convert.ToBoolean(value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Set true to save the propoerty - (Enabled) in xml file
        /// </summary>
        [XmlIgnore]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }

            set
            {
                this.enabledFieldSpecified = value;
            }
        }

        /// <summary>
        /// Specify the Server type
        /// </summary>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }

            set
            {
                this.extensionField = value;
            }
        }

        /// <summary>
        /// Set to true to impersonate  the authenticated user after a connection has been made to the datasource
        /// </summary>
        public bool ImpersonateUser
        {
            get
            {
                return this.impersonateUserField;
            }

            set
            {
                this.impersonateUserField = value;
            }
        }

        /// <summary>
        /// Set true to save the impersonate user in xml file
        /// </summary>
        [XmlIgnore]
        public bool ImpersonateUserSpecified
        {
            get
            {
                return this.impersonateUserFieldSpecified;
            }

            set
            {
                this.impersonateUserFieldSpecified = value;
            }
        }

        /// <summary>
        /// Specifies the original connection string
        /// </summary>
        public bool OriginalConnectStringExpressionBased
        {
            get
            {
                return this.originalConnectStringExpressionBasedField;
            }

            set
            {
                this.originalConnectStringExpressionBasedField = value;
            }
        }

        /// <summary>
        /// Specifies the password of connection credentials
        /// </summary>
        public string Password
        {
            get
            {
                return this.passwordField;
            }

            set
            {
                this.passwordField = value;
            }
        }

        /// <summary>
        /// Specifies the text that prompts users for a username and password
        /// </summary>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }

            set
            {
                this.promptField = value;
            }
        }

        /// <summary>
        /// Specifies whether to use origingal connection string
        /// </summary>
        public bool UseOriginalConnectString
        {
            get
            {
                return this.useOriginalConnectStringField;
            }

            set
            {
                this.useOriginalConnectStringField = value;
            }
        }

        /// <summary>
        /// Specifies the username of connection credentials
        /// </summary>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }

            set
            {
                this.userNameField = value;
            }
        }

        /// <summary>
        /// Set to true to use Windows credentials when connecting to the datasource
        /// </summary>
        public bool WindowsCredentials
        {
            get
            {
                return this.windowsCredentialsField;
            }

            set
            {
                this.windowsCredentialsField = value;
            }
        }

        /// <summary>
        /// Set true to save the windows credentials in xml file
        /// </summary>
        [XmlIgnore]
        public bool WindowsCredentialsSpecified
        {
            get
            {
                return this.windowsCredentialsFieldSpecified;
            }

            set
            {
                this.windowsCredentialsFieldSpecified = value;
            }
        }

        #region property used in api
        /// <summary>
        /// Specify the server type
        /// </summary>
        [XmlIgnore]
        public ServerType ServerType
        {
            get;
            set;
        }

        #endregion
    }
}