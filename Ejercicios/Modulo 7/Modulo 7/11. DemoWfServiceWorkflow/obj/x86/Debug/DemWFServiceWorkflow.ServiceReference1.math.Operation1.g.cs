//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.269
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DemWFServiceWorkflow.ServiceReference1.Activities {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class Operation1 : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private string _EndpointConfigurationName;
        
        private System.Activities.InArgument<int> _xIn;
        
        private System.Activities.InArgument<int> _yIn;
        
        private System.Activities.OutArgument<int> _sumar;
        
        public Operation1() {
            this.InitializeComponent();
        }
        
        public string EndpointConfigurationName {
            get {
                return this._EndpointConfigurationName;
            }
            set {
                this._EndpointConfigurationName = value;
            }
        }
        
        [System.Activities.RequiredArgumentAttribute()]
        public System.Activities.InArgument<int> xIn {
            get {
                return this._xIn;
            }
            set {
                this._xIn = value;
            }
        }
        
        [System.Activities.RequiredArgumentAttribute()]
        public System.Activities.InArgument<int> yIn {
            get {
                return this._yIn;
            }
            set {
                this._yIn = value;
            }
        }
        
        public System.Activities.OutArgument<int> sumar {
            get {
                return this._sumar;
            }
            set {
                this._sumar = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if ((this._contentLoaded == true)) {
                return;
            }
            this._contentLoaded = true;
            string resourceName = this.FindResource();
            System.IO.Stream initializeXaml = typeof(Operation1).Assembly.GetManifestResourceStream(resourceName);
            System.Xml.XmlReader xmlReader = null;
            System.Xaml.XamlReader reader = null;
            System.Xaml.XamlObjectWriter objectWriter = null;
            try {
                System.Xaml.XamlSchemaContext schemaContext = XamlStaticHelperNamespace._XamlStaticHelper.SchemaContext;
                xmlReader = System.Xml.XmlReader.Create(initializeXaml);
                System.Xaml.XamlXmlReaderSettings readerSettings = new System.Xaml.XamlXmlReaderSettings();
                readerSettings.LocalAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                readerSettings.AllowProtectedMembersOnRoot = true;
                reader = new System.Xaml.XamlXmlReader(xmlReader, schemaContext, readerSettings);
                System.Xaml.XamlObjectWriterSettings writerSettings = new System.Xaml.XamlObjectWriterSettings();
                writerSettings.RootObjectInstance = this;
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(Operation1));
                objectWriter = new System.Xaml.XamlObjectWriter(schemaContext, writerSettings);
                System.Xaml.XamlServices.Transform(reader, objectWriter);
            }
            finally {
                if ((xmlReader != null)) {
                    ((System.IDisposable)(xmlReader)).Dispose();
                }
                if ((reader != null)) {
                    ((System.IDisposable)(reader)).Dispose();
                }
                if ((objectWriter != null)) {
                    ((System.IDisposable)(objectWriter)).Dispose();
                }
            }
        }
        
        private string FindResource() {
            string[] resources = typeof(Operation1).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".DemWFServiceWorkflow.ServiceReference1.math.Operation1.g.xaml") || resource.Equals("DemWFServiceWorkflow.ServiceReference1.math.Operation1.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}
