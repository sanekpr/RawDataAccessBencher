﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Production
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.CollectionTypeConverter))]
    public partial class ProductModelCollection : System.Collections.IList, CodeFluent.Runtime.ICodeFluentSet, System.Collections.Generic.IList<CodeFluentEntities.Bencher.Production.ProductModel>, System.ComponentModel.IRaiseItemChangedEvents, System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.IBindingList, System.ComponentModel.ICancelAddNew
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private bool _raiseCollectionChangedEvents = true;
        
        [System.NonSerializedAttribute()]
        private System.Collections.Generic.List<CodeFluentEntities.Bencher.Production.ProductModel> _baseList = new System.Collections.Generic.List<CodeFluentEntities.Bencher.Production.ProductModel>();
        
        [System.NonSerializedAttribute()]
        private System.Collections.Hashtable _relations = new System.Collections.Hashtable();
        
        private int _maxCount = 2147483647;
        
        [System.NonSerializedAttribute()]
        private int _addNewPos = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluent.Runtime.Utilities.BindingListManager<CodeFluentEntities.Bencher.Production.ProductModel> _blm2029827079;
        
        private bool _raiseListChangedEvents = true;
        
        private System.Collections.Specialized.NotifyCollectionChangedEventHandler _h2943838991;

        event System.Collections.Specialized.NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged{add{_h2943838991+=value;}remove{_h2943838991-=value;}}
        
        public ProductModelCollection()
        {
            this._blm2029827079 = new CodeFluent.Runtime.Utilities.BindingListManager<CodeFluentEntities.Bencher.Production.ProductModel>(this);
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual bool RaiseCollectionChangedEvents
        {
            get
            {
                return this._raiseCollectionChangedEvents;
            }
            set
            {
                this._raiseCollectionChangedEvents = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        protected System.Collections.Generic.List<CodeFluentEntities.Bencher.Production.ProductModel> BaseList
        {
            get
            {
                return this._baseList;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        System.Collections.IDictionary CodeFluent.Runtime.ICodeFluentSet.Relations
        {
            get
            {
                return this._relations;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        public virtual int MaxCount
        {
            get
            {
                return this._maxCount;
            }
            set
            {
                this._maxCount = value;
            }
        }
        
        public CodeFluentEntities.Bencher.Production.ProductModel this[int index]
        {
            get
            {
                return ((CodeFluentEntities.Bencher.Production.ProductModel)(this.BaseList[index]));
            }
            set
            {
                this.BaseList[index] = value;
            }
        }
        
        object System.Collections.IList.this[int index]
        {
            get
            {
                object i = this.BaseList[index];
                return i;
            }
            set
            {
                this.BaseList[index] = ((CodeFluentEntities.Bencher.Production.ProductModel)(value));
            }
        }
        
        public virtual int Count
        {
            get
            {
                int v = ((System.Collections.IList)(this.BaseList)).Count;
                return v;
            }
        }
        
        public virtual bool IsSynchronized
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsSynchronized;
                return v;
            }
        }
        
        public virtual object SyncRoot
        {
            get
            {
                object v = ((System.Collections.IList)(this.BaseList)).SyncRoot;
                return v;
            }
        }
        
        public virtual bool IsFixedSize
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsFixedSize;
                return v;
            }
        }
        
        public virtual bool IsReadOnly
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsReadOnly;
                return v;
            }
        }
        
        public virtual bool RaiseListChangedEvents
        {
            get
            {
                return this._raiseListChangedEvents;
            }
            set
            {
                this._raiseListChangedEvents = value;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowEdit
        {
            get
            {
                return this._blm2029827079.AllowEdit;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowNew
        {
            get
            {
                return this._blm2029827079.AllowNew;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowRemove
        {
            get
            {
                return this._blm2029827079.AllowRemove;
            }
        }
        
        bool System.ComponentModel.IBindingList.IsSorted
        {
            get
            {
                return this._blm2029827079.IsSorted;
            }
        }
        
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection
        {
            get
            {
                return this._blm2029827079.SortDirection;
            }
        }
        
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
        {
            get
            {
                return this._blm2029827079.SortProperty;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsChangeNotification
        {
            get
            {
                return true;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsSearching
        {
            get
            {
                return this._blm2029827079.SupportsSearching;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsSorting
        {
            get
            {
                return this._blm2029827079.SupportsSorting;
            }
        }
        
        bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents
        {
            get
            {
                return this.RaiseListChangedEvents;
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.AddingNewEventHandler AddingNew;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.ListChangedEventHandler ListChanged;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs e)
        {
            if ((this.RaiseCollectionChangedEvents == false))
            {
                return;
            }
            if ((this.CollectionChanged != null))
            {
                this.CollectionChanged(this, e);
            }
            CodeFluent.Runtime.ServiceModel.CollectionChangeNotifier.Notify(this, e, this._h2943838991);
            this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Count"));
            this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Item[]"));
        }
        
        protected virtual void Relate(CodeFluentEntities.Bencher.Production.ProductModel item, CodeFluent.Runtime.CodeFluentRelationType relationType)
        {
            ((CodeFluent.Runtime.ICodeFluentSet)(this)).Relations[item] = relationType;
        }
        
        public int Add(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            int localAdd = this.BaseList.Count;
            this.BaseAdd(productModel);
            return localAdd;
        }
        
        protected virtual int BaseAdd(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            if ((productModel == null))
            {
                throw new System.ArgumentNullException("productModel");
            }
            if ((productModel.ProductModelID == -1))
            {
                CodeFluent.Runtime.CodeFluentRuntimeException.Throw("invalidEntityKey", "ProductModelID", "productModel", "CodeFluentEntities.Bencher.Production.ProductModel");
            }
            int localAdd = this.BaseList.Count;
            this.BaseList.Add(productModel);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Add, productModel, localAdd));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemAdded, localAdd));
            return localAdd;
        }
        
        int System.Collections.IList.Add(object value)
        {
            CodeFluentEntities.Bencher.Production.ProductModel productModel = null;
            try
            {
                productModel = ((CodeFluentEntities.Bencher.Production.ProductModel)(value));
            }
            catch (System.InvalidCastException )
            {
                string key = null;
                try
                {
                    key = ((string)(value));
                    int count = this.Count;
                    if ((this.AddByEntityKey(key) != null))
                    {
                        return 1;
                    }
                    return 0;
                }
                catch (System.InvalidCastException )
                {
                }
                if ((key == null))
                {
                    throw new System.ArgumentException("value");
                }
            }
            if ((productModel == null))
            {
                throw new System.ArgumentException("value");
            }
            int localAdd = this.Add(productModel);
            return localAdd;
        }
        
        void System.Collections.Generic.ICollection<CodeFluentEntities.Bencher.Production.ProductModel>.Add(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            this.BaseAdd(productModel);
        }
        
        public virtual CodeFluentEntities.Bencher.Production.ProductModel AddByEntityKey(string key)
        {
            CodeFluentEntities.Bencher.Production.ProductModel productModel = CodeFluentEntities.Bencher.Production.ProductModel.LoadByEntityKey(key);
            if (((productModel != null) 
                        && (this.Contains(productModel) == false)))
            {
                this.Add(productModel);
            }
            return productModel;
        }
        
        public void Sort()
        {
            this.Sort(null);
        }
        
        public virtual void Sort(System.Collections.Generic.IComparer<CodeFluentEntities.Bencher.Production.ProductModel> comparer)
        {
            this.BaseList.Sort(comparer);
        }
        
        public void CopyTo(CodeFluentEntities.Bencher.Production.ProductModel[] array, int index)
        {
            this.BaseCopyTo(array, index);
        }
        
        protected virtual void BaseCopyTo(CodeFluentEntities.Bencher.Production.ProductModel[] array, int index)
        {
            this.BaseList.CopyTo(array, index);
        }
        
        void System.Collections.ICollection.CopyTo(System.Array array, int index)
        {
            CodeFluent.Runtime.Utilities.ConvertUtilities.CopyTo(this, array, index);
        }
        
        public bool Contains(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            bool localContains = this.BaseContains(productModel);
            return localContains;
        }
        
        protected virtual bool BaseContains(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            if ((productModel == null))
            {
                return false;
            }
            bool localContains = this.BaseList.Contains(productModel);
            return localContains;
        }
        
        bool System.Collections.IList.Contains(object value)
        {
            CodeFluentEntities.Bencher.Production.ProductModel productModel;
			productModel = value as CodeFluentEntities.Bencher.Production.ProductModel;
            return this.Contains(productModel);
        }
        
        public int IndexOf(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            int localIndexOf = this.BaseIndexOf(productModel);
            return localIndexOf;
        }
        
        protected virtual int BaseIndexOf(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            if ((productModel == null))
            {
                return -1;
            }
            int localIndexOf = this.BaseList.IndexOf(productModel);
            return localIndexOf;
        }
        
        int System.Collections.IList.IndexOf(object value)
        {
            CodeFluentEntities.Bencher.Production.ProductModel productModel;
			productModel = value as CodeFluentEntities.Bencher.Production.ProductModel;
            return this.IndexOf(productModel);
        }
        
        public void Insert(int index, CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            this.BaseInsert(index, productModel);
        }
        
        protected virtual void BaseInsert(int index, CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            if ((productModel == null))
            {
                throw new System.ArgumentNullException("productModel");
            }
            this.BaseList.Insert(index, productModel);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Add, productModel, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemAdded, index));
        }
        
        void System.Collections.IList.Insert(int index, object value)
        {
            CodeFluentEntities.Bencher.Production.ProductModel productModel;
			productModel = value as CodeFluentEntities.Bencher.Production.ProductModel;
            this.Insert(index, productModel);
        }
        
        public virtual void Clear()
        {
            int index;
            int count = this.Count;
            for (index = 0; (index < count); index = (index + 1))
            {
                CodeFluentEntities.Bencher.Production.ProductModel ProductModel = this[0];
                this.BaseRemove(ProductModel);
            }
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Refresh, null));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, -1));
        }
        
        public bool Remove(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            return this.BaseRemove(productModel);
        }
        
        protected virtual bool BaseRemove(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            if ((productModel == null))
            {
                throw new System.ArgumentNullException("productModel");
            }
            int index = this.IndexOf(productModel);
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(((System.ComponentModel.ListChangedType)(CodeFluent.Runtime.Utilities.SortableBindingList<CodeFluentEntities.Bencher.Production.ProductModel>.ListChangedTypeDeleting)), index));
            bool ret;
            ret = this.BaseList.Remove(productModel);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Remove, productModel, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemDeleted, index));
            return ret;
        }
        
        void System.Collections.IList.Remove(object value)
        {
            CodeFluentEntities.Bencher.Production.ProductModel productModel;
			productModel = value as CodeFluentEntities.Bencher.Production.ProductModel;
            this.Remove(productModel);
        }
        
        public virtual void RemoveAt(int index)
        {
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(((System.ComponentModel.ListChangedType)(CodeFluent.Runtime.Utilities.SortableBindingList<CodeFluentEntities.Bencher.Production.ProductModel>.ListChangedTypeDeleting)), index));
            CodeFluentEntities.Bencher.Production.ProductModel productModel = this.BaseList[index];
            this.BaseList.RemoveAt(index);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Remove, productModel, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemDeleted, index));
        }
        
        public virtual System.Collections.Generic.IEnumerator<CodeFluentEntities.Bencher.Production.ProductModel> GetEnumerator()
        {
            System.Collections.Generic.IEnumerator<CodeFluentEntities.Bencher.Production.ProductModel> e = this.BaseList.GetEnumerator();
            return e;
        }
        
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.BaseList.GetEnumerator();
        }
        
        public virtual void SaveAll()
        {
            int index;
            for (index = (this.Count - 1); (index >= 0); index = (index - 1))
            {
                CodeFluentEntities.Bencher.Production.ProductModel productModel = this[index];
                productModel.Save();
                if ((productModel.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
                {
                    this.Remove(productModel);
                }
            }
        }
        
        private void LoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions, System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((pageIndex < 0))
            {
                pageIndex = 0;
            }
            if ((pageSize < 0))
            {
                if ((pageOptions != null))
                {
                    pageSize = pageOptions.DefaultPageSize;
                }
                else
                {
                    pageSize = int.MaxValue;
                }
            }
            this.BaseList.Clear();
            int count = 0;
            int readCount = 0;
            bool readerRead;
            for (readerRead = reader.Read(); ((readerRead == true) 
                        && ((count < this.MaxCount) 
                        && (count < pageSize))); readerRead = reader.Read())
            {
                readCount = (readCount + 1);
                if ((CodeFluent.Runtime.CodeFluentPersistence.CanAddEntity(pageIndex, pageSize, pageOptions, readCount) == true))
                {
                    CodeFluentEntities.Bencher.Production.ProductModel productModel = new CodeFluentEntities.Bencher.Production.ProductModel();
                    ((CodeFluent.Runtime.ICodeFluentEntity)(productModel)).ReadRecord(reader);
                    if ((this.BaseContains(productModel) == false))
                    {
                        this.BaseAdd(productModel);
                        count = (count + 1);
                    }
                    productModel.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                }
            }
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.ProductModelCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions)
        {
            if ((pageIndex < 0))
            {
                pageIndex = 0;
            }
            if ((pageSize < 0))
            {
                if ((pageOptions != null))
                {
                    pageSize = pageOptions.DefaultPageSize;
                }
                else
                {
                    pageSize = int.MaxValue;
                }
            }
            CodeFluentEntities.Bencher.Production.ProductModelCollection ret = new CodeFluentEntities.Bencher.Production.ProductModelCollection();
            System.Data.IDataReader reader = null;
            try
            {
                reader = CodeFluentEntities.Bencher.Production.ProductModelCollection.PageDataLoadAll(pageOptions);
                if ((reader == null))
                {
                    return ret;
                }
                ret.LoadAll(pageIndex, pageSize, pageOptions, reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                CodeFluent.Runtime.CodeFluentPersistence.CompleteCommand(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName);
            }
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.ProductModelCollection LoadAll()
        {
            CodeFluentEntities.Bencher.Production.ProductModelCollection ret = CodeFluentEntities.Bencher.Production.ProductModelCollection.PageLoadAll(int.MinValue, int.MaxValue, null);
            return ret;
        }
        
        public static System.Data.IDataReader PageDataLoadAll(CodeFluent.Runtime.PageOptions pageOptions)
        {
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Production", "ProductModel", "LoadAll");
            if ((pageOptions != null))
            {
                System.Collections.IEnumerator enumerator = pageOptions.OrderByArguments.GetEnumerator();
                bool b;
                int index = 0;
                for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
                {
                    CodeFluent.Runtime.OrderByArgument argument = ((CodeFluent.Runtime.OrderByArgument)(enumerator.Current));
                    persistence.AddParameter(string.Format("@_orderBy{0}", index), argument.Name);
                    persistence.AddParameter(string.Format("@_orderByDirection{0}", index), ((int)(argument.Direction)));
                    index = (index + 1);
                }
            }
            System.Data.IDataReader reader = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence.ExecuteReader();
            return reader;
        }
        
        public static System.Data.IDataReader DataLoadAll()
        {
            System.Data.IDataReader reader = CodeFluentEntities.Bencher.Production.ProductModelCollection.PageDataLoadAll(null);
            return reader;
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write(string.Concat("Count=", this.Count));
            writer.Write("]");
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Production.ProductModelCollection collection, bool deep)
        {
            if ((typeof(System.ICloneable).IsAssignableFrom(typeof(CodeFluentEntities.Bencher.Production.ProductModel)) == false))
            {
                deep = false;
            }
            System.Collections.Generic.IEnumerator<CodeFluentEntities.Bencher.Production.ProductModel> enumerator = this.GetEnumerator();
            bool b;
            for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
            {
                if ((deep == true))
                {
                    collection.Add(((CodeFluentEntities.Bencher.Production.ProductModel)(((System.ICloneable)(enumerator.Current)).Clone())));
                }
                else
                {
                    collection.Add(enumerator.Current);
                }
            }
        }
        
        public virtual CodeFluentEntities.Bencher.Production.ProductModelCollection Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Production.ProductModelCollection ret = new CodeFluentEntities.Bencher.Production.ProductModelCollection();
            this.CopyTo(ret, deep);
            return ret;
        }
        
        object System.ICloneable.Clone()
        {
            return this.Clone(true);
        }
        
        public virtual void CancelNew(int index)
        {
            if (((this._addNewPos >= 0) 
                        && (this._addNewPos == index)))
            {
                this.RemoveAt(index);
                this._addNewPos = -1;
            }
        }
        
        public virtual void EndNew(int index)
        {
            if (((this._addNewPos >= 0) 
                        && (this._addNewPos == index)))
            {
                this._addNewPos = -1;
            }
        }
        
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property)
        {
            this._blm2029827079.AddIndex(property);
        }
        
        protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e)
        {
            if ((this.AddingNew != null))
            {
                this.AddingNew(this, e);
            }
        }
        
        object System.ComponentModel.IBindingList.AddNew()
        {
            CodeFluentEntities.Bencher.Production.ProductModel add = new CodeFluentEntities.Bencher.Production.ProductModel();
            System.ComponentModel.AddingNewEventArgs e = new System.ComponentModel.AddingNewEventArgs(add);
            this.OnAddingNew(e);
            add = ((CodeFluentEntities.Bencher.Production.ProductModel)(e.NewObject));
            if ((add == null))
            {
                add = new CodeFluentEntities.Bencher.Production.ProductModel();
            }
            this._addNewPos = this.Add(add);
            return add;
        }
        
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
        {
            this._blm2029827079.ApplySort(property, direction);
        }
        
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key)
        {
            return this._blm2029827079.Find(property, key);
        }
        
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property)
        {
            this._blm2029827079.RemoveIndex(property);
        }
        
        void System.ComponentModel.IBindingList.RemoveSort()
        {
            this._blm2029827079.RemoveSort();
        }
        
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
        {
            if ((e == null))
            {
                throw new System.ArgumentNullException("e");
            }
            if ((this.RaiseListChangedEvents == false))
            {
                return;
            }
            if ((((e.ListChangedType == System.ComponentModel.ListChangedType.Reset) 
                        == false) 
                        && (e.NewIndex < 0)))
            {
                return;
            }
            if ((this.ListChanged != null))
            {
                this.ListChanged(this, e);
            }
        }
        
        public void AddRange(System.Collections.Generic.IEnumerable<CodeFluentEntities.Bencher.Production.ProductModel> collection)
        {
            CodeFluent.Runtime.Utilities.ConvertUtilities.AddRange(this, collection);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Production.ProductModelCollection PageLoadAll(int pageIndex, int pageSize)
        {
            return CodeFluentEntities.Bencher.Production.ProductModelCollection.PageLoadAll(pageIndex, pageSize, null);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            if ((productModel == null))
            {
                return false;
            }
            bool ret = productModel.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            bool ret = CodeFluentEntities.Bencher.Production.ProductModel.Save(productModel);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Production.ProductModel productModel)
        {
            if ((productModel == null))
            {
                return false;
            }
            bool ret = productModel.Delete();
            return ret;
        }
    }
}
