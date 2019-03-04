namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Runtime.Serialization;
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
    [DataContract]
    public class DataSourceDefinition
    {
        /// <summary>
        /// Datasource connection string
        /// </summary>
        [DataMember]
        public string ConnectString
        {
            get;
            set;
        }

        /// <summary>
        /// Set the type of credentials to secure data
        /// </summary>
        [DataMember]
        public CredentialRetrieval CredentialRetrieval
        {
            get;
            set;
        }

        /// <summary>
        /// Set true if modifying the datasource connection details
        /// </summary>
        [DataMember]
        public bool Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Set true to save the propoerty - (Enabled) in xml file
        /// </summary>
        [XmlIgnore]
        [DataMember]
        public bool EnabledSpecified
        {
            get;
            set;
        }

        /// <summary>
        /// Specify the Server type
        /// </summary>
        [DataMember]
        public string Extension
        {
            get;
            set;
        }

        /// <summary>
        /// Set to true to impersonate  the authenticated user after a connection has been made to the datasource
        /// </summary>
        [DataMember]
        public bool ImpersonateUser
        {
            get;
            set;
        }

        /// <summary>
        /// Set true to save the impersonate user in xml file
        /// </summary>
        [XmlIgnore]
        [DataMember]
        public bool ImpersonateUserSpecified
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the original connection string
        /// </summary>
        [DataMember]
        public bool OriginalConnectStringExpressionBased
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the password of connection credentials
        /// </summary>
        [DataMember]
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the text that prompts users for a username and password
        /// </summary>
        [DataMember]
        public string Prompt
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies whether to use origingal connection string
        /// </summary>
        [DataMember]
        public bool UseOriginalConnectString
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the username of connection credentials
        /// </summary>
        [DataMember]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Set to true to use Windows credentials when connecting to the datasource
        /// </summary>
        [DataMember]
        public bool WindowsCredentials
        {
            get;
            set;
        }

        /// <summary>
        /// Set true to save the windows credentials in xml file
        /// </summary>
        [XmlIgnore]
        [DataMember]
        public bool WindowsCredentialsSpecified
        {
            get;
            set;
        }

        #region property used in api
        /// <summary>
        /// Specify the server type
        /// </summary>
        [XmlIgnore]
        [DataMember]
        public ServerType ServerType
        {
            get;
            set;
        }

        #endregion
    }
}