﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfUi.ImageServiceReferense {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Image", Namespace="http://schemas.datacontract.org/2004/07/WcfApi")]
    [System.SerializableAttribute()]
    public partial class Image : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ImageServiceReferense.IImageService")]
    public interface IImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/GetAll", ReplyAction="http://tempuri.org/IImageService/GetAllResponse")]
        WpfUi.ImageServiceReferense.Image[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/GetAll", ReplyAction="http://tempuri.org/IImageService/GetAllResponse")]
        System.IAsyncResult BeginGetAll(System.AsyncCallback callback, object asyncState);
        
        WpfUi.ImageServiceReferense.Image[] EndGetAll(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/Get", ReplyAction="http://tempuri.org/IImageService/GetResponse")]
        WpfUi.ImageServiceReferense.Image Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/Get", ReplyAction="http://tempuri.org/IImageService/GetResponse")]
        System.IAsyncResult BeginGet(int id, System.AsyncCallback callback, object asyncState);
        
        WpfUi.ImageServiceReferense.Image EndGet(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/Update", ReplyAction="http://tempuri.org/IImageService/UpdateResponse")]
        void Update(WpfUi.ImageServiceReferense.Image image);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/Update", ReplyAction="http://tempuri.org/IImageService/UpdateResponse")]
        System.IAsyncResult BeginUpdate(WpfUi.ImageServiceReferense.Image image, System.AsyncCallback callback, object asyncState);
        
        void EndUpdate(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/Create", ReplyAction="http://tempuri.org/IImageService/CreateResponse")]
        void Create(WpfUi.ImageServiceReferense.Image image);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/Create", ReplyAction="http://tempuri.org/IImageService/CreateResponse")]
        System.IAsyncResult BeginCreate(WpfUi.ImageServiceReferense.Image image, System.AsyncCallback callback, object asyncState);
        
        void EndCreate(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImageService/Delete", ReplyAction="http://tempuri.org/IImageService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/Delete", ReplyAction="http://tempuri.org/IImageService/DeleteResponse")]
        System.IAsyncResult BeginDelete(int id, System.AsyncCallback callback, object asyncState);
        
        void EndDelete(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImageServiceChannel : WpfUi.ImageServiceReferense.IImageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public WpfUi.ImageServiceReferense.Image[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((WpfUi.ImageServiceReferense.Image[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public WpfUi.ImageServiceReferense.Image Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((WpfUi.ImageServiceReferense.Image)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImageServiceClient : System.ServiceModel.ClientBase<WpfUi.ImageServiceReferense.IImageService>, WpfUi.ImageServiceReferense.IImageService {
        
        private BeginOperationDelegate onBeginGetAllDelegate;
        
        private EndOperationDelegate onEndGetAllDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetDelegate;
        
        private EndOperationDelegate onEndGetDelegate;
        
        private System.Threading.SendOrPostCallback onGetCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateDelegate;
        
        private EndOperationDelegate onEndUpdateDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreateDelegate;
        
        private EndOperationDelegate onEndCreateDelegate;
        
        private System.Threading.SendOrPostCallback onCreateCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeleteDelegate;
        
        private EndOperationDelegate onEndDeleteDelegate;
        
        private System.Threading.SendOrPostCallback onDeleteCompletedDelegate;
        
        public ImageServiceClient() {
        }
        
        public ImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetAllCompletedEventArgs> GetAllCompleted;
        
        public event System.EventHandler<GetCompletedEventArgs> GetCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UpdateCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CreateCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DeleteCompleted;
        
        public WpfUi.ImageServiceReferense.Image[] GetAll() {
            return base.Channel.GetAll();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAll(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAll(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public WpfUi.ImageServiceReferense.Image[] EndGetAll(System.IAsyncResult result) {
            return base.Channel.EndGetAll(result);
        }
        
        private System.IAsyncResult OnBeginGetAll(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAll(callback, asyncState);
        }
        
        private object[] OnEndGetAll(System.IAsyncResult result) {
            WpfUi.ImageServiceReferense.Image[] retVal = this.EndGetAll(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllCompleted(object state) {
            if ((this.GetAllCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllCompleted(this, new GetAllCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllAsync() {
            this.GetAllAsync(null);
        }
        
        public void GetAllAsync(object userState) {
            if ((this.onBeginGetAllDelegate == null)) {
                this.onBeginGetAllDelegate = new BeginOperationDelegate(this.OnBeginGetAll);
            }
            if ((this.onEndGetAllDelegate == null)) {
                this.onEndGetAllDelegate = new EndOperationDelegate(this.OnEndGetAll);
            }
            if ((this.onGetAllCompletedDelegate == null)) {
                this.onGetAllCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllDelegate, null, this.onEndGetAllDelegate, this.onGetAllCompletedDelegate, userState);
        }
        
        public WpfUi.ImageServiceReferense.Image Get(int id) {
            return base.Channel.Get(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGet(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGet(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public WpfUi.ImageServiceReferense.Image EndGet(System.IAsyncResult result) {
            return base.Channel.EndGet(result);
        }
        
        private System.IAsyncResult OnBeginGet(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return this.BeginGet(id, callback, asyncState);
        }
        
        private object[] OnEndGet(System.IAsyncResult result) {
            WpfUi.ImageServiceReferense.Image retVal = this.EndGet(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCompleted(object state) {
            if ((this.GetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCompleted(this, new GetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAsync(int id) {
            this.GetAsync(id, null);
        }
        
        public void GetAsync(int id, object userState) {
            if ((this.onBeginGetDelegate == null)) {
                this.onBeginGetDelegate = new BeginOperationDelegate(this.OnBeginGet);
            }
            if ((this.onEndGetDelegate == null)) {
                this.onEndGetDelegate = new EndOperationDelegate(this.OnEndGet);
            }
            if ((this.onGetCompletedDelegate == null)) {
                this.onGetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCompleted);
            }
            base.InvokeAsync(this.onBeginGetDelegate, new object[] {
                        id}, this.onEndGetDelegate, this.onGetCompletedDelegate, userState);
        }
        
        public void Update(WpfUi.ImageServiceReferense.Image image) {
            base.Channel.Update(image);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUpdate(WpfUi.ImageServiceReferense.Image image, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdate(image, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndUpdate(System.IAsyncResult result) {
            base.Channel.EndUpdate(result);
        }
        
        private System.IAsyncResult OnBeginUpdate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WpfUi.ImageServiceReferense.Image image = ((WpfUi.ImageServiceReferense.Image)(inValues[0]));
            return this.BeginUpdate(image, callback, asyncState);
        }
        
        private object[] OnEndUpdate(System.IAsyncResult result) {
            this.EndUpdate(result);
            return null;
        }
        
        private void OnUpdateCompleted(object state) {
            if ((this.UpdateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateAsync(WpfUi.ImageServiceReferense.Image image) {
            this.UpdateAsync(image, null);
        }
        
        public void UpdateAsync(WpfUi.ImageServiceReferense.Image image, object userState) {
            if ((this.onBeginUpdateDelegate == null)) {
                this.onBeginUpdateDelegate = new BeginOperationDelegate(this.OnBeginUpdate);
            }
            if ((this.onEndUpdateDelegate == null)) {
                this.onEndUpdateDelegate = new EndOperationDelegate(this.OnEndUpdate);
            }
            if ((this.onUpdateCompletedDelegate == null)) {
                this.onUpdateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateDelegate, new object[] {
                        image}, this.onEndUpdateDelegate, this.onUpdateCompletedDelegate, userState);
        }
        
        public void Create(WpfUi.ImageServiceReferense.Image image) {
            base.Channel.Create(image);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginCreate(WpfUi.ImageServiceReferense.Image image, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreate(image, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndCreate(System.IAsyncResult result) {
            base.Channel.EndCreate(result);
        }
        
        private System.IAsyncResult OnBeginCreate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WpfUi.ImageServiceReferense.Image image = ((WpfUi.ImageServiceReferense.Image)(inValues[0]));
            return this.BeginCreate(image, callback, asyncState);
        }
        
        private object[] OnEndCreate(System.IAsyncResult result) {
            this.EndCreate(result);
            return null;
        }
        
        private void OnCreateCompleted(object state) {
            if ((this.CreateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateAsync(WpfUi.ImageServiceReferense.Image image) {
            this.CreateAsync(image, null);
        }
        
        public void CreateAsync(WpfUi.ImageServiceReferense.Image image, object userState) {
            if ((this.onBeginCreateDelegate == null)) {
                this.onBeginCreateDelegate = new BeginOperationDelegate(this.OnBeginCreate);
            }
            if ((this.onEndCreateDelegate == null)) {
                this.onEndCreateDelegate = new EndOperationDelegate(this.OnEndCreate);
            }
            if ((this.onCreateCompletedDelegate == null)) {
                this.onCreateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateCompleted);
            }
            base.InvokeAsync(this.onBeginCreateDelegate, new object[] {
                        image}, this.onEndCreateDelegate, this.onCreateCompletedDelegate, userState);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDelete(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDelete(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndDelete(System.IAsyncResult result) {
            base.Channel.EndDelete(result);
        }
        
        private System.IAsyncResult OnBeginDelete(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return this.BeginDelete(id, callback, asyncState);
        }
        
        private object[] OnEndDelete(System.IAsyncResult result) {
            this.EndDelete(result);
            return null;
        }
        
        private void OnDeleteCompleted(object state) {
            if ((this.DeleteCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeleteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeleteAsync(int id) {
            this.DeleteAsync(id, null);
        }
        
        public void DeleteAsync(int id, object userState) {
            if ((this.onBeginDeleteDelegate == null)) {
                this.onBeginDeleteDelegate = new BeginOperationDelegate(this.OnBeginDelete);
            }
            if ((this.onEndDeleteDelegate == null)) {
                this.onEndDeleteDelegate = new EndOperationDelegate(this.OnEndDelete);
            }
            if ((this.onDeleteCompletedDelegate == null)) {
                this.onDeleteCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteCompleted);
            }
            base.InvokeAsync(this.onBeginDeleteDelegate, new object[] {
                        id}, this.onEndDeleteDelegate, this.onDeleteCompletedDelegate, userState);
        }
    }
}