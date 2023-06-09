﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FerrelectricosRYF
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BDFerrelectricos")]
	public partial class ModeloDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertClientes(Clientes instance);
    partial void UpdateClientes(Clientes instance);
    partial void DeleteClientes(Clientes instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    partial void InsertProductos(Productos instance);
    partial void UpdateProductos(Productos instance);
    partial void DeleteProductos(Productos instance);
    partial void InsertProveedores(Proveedores instance);
    partial void UpdateProveedores(Proveedores instance);
    partial void DeleteProveedores(Proveedores instance);
    #endregion
		
		public ModeloDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Clientes> Clientes
		{
			get
			{
				return this.GetTable<Clientes>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<Productos> Productos
		{
			get
			{
				return this.GetTable<Productos>();
			}
		}
		
		public System.Data.Linq.Table<Proveedores> Proveedores
		{
			get
			{
				return this.GetTable<Proveedores>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.actualizarClientes")]
		public int actualizarClientes([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(50)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="VarChar(50)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Correo", DbType="VarChar(50)")] string correo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, nombre, direccion, telefono, correo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarClientes")]
		public ISingleResult<buscarClientesResult> buscarClientes([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<buscarClientesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.eliminarClientes")]
		public int eliminarClientes([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertarClientes")]
		public int insertarClientes([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(50)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="VarChar(50)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Correo", DbType="VarChar(50)")] string correo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, nombre, direccion, telefono, correo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.actualizarUsuarios")]
		public int actualizarUsuarios([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(50)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cargo", DbType="VarChar(50)")] string cargo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, nombre, contraseña, cargo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarUsuarios")]
		public ISingleResult<buscarUsuariosResult> buscarUsuarios([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<buscarUsuariosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.eliminarUsuarios")]
		public int eliminarUsuarios([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertarUsuarios")]
		public int insertarUsuarios([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(50)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cargo", DbType="VarChar(50)")] string cargo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, nombre, contraseña, cargo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.actualizarProductos")]
		public int actualizarProductos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripccion", DbType="VarChar(50)")] string descripccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ValorUnitario", DbType="Int")] System.Nullable<int> valorUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Existencia", DbType="Int")] System.Nullable<int> existencia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDProveedor", DbType="Int")] System.Nullable<int> iDProveedor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, nombre, descripccion, valorUnitario, existencia, iDProveedor);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarProductos")]
		public ISingleResult<buscarProductosResult> buscarProductos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<buscarProductosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.eliminarProductos")]
		public int eliminarProductos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertarProductos")]
		public int insertarProductos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripccion", DbType="VarChar(50)")] string descripccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ValorUnitario", DbType="Int")] System.Nullable<int> valorUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Existencia", DbType="Int")] System.Nullable<int> existencia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDProveedor", DbType="Int")] System.Nullable<int> iDProveedor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, nombre, descripccion, valorUnitario, existencia, iDProveedor);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.actualizarProveedores")]
		public int actualizarProveedores([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nit", DbType="Int")] System.Nullable<int> nit, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Empresa", DbType="VarChar(50)")] string empresa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(50)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="VarChar(50)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Correo", DbType="VarChar(50)")] string correo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nit, empresa, direccion, telefono, correo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarProveedores")]
		public ISingleResult<buscarProveedoresResult> buscarProveedores([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nit", DbType="Int")] System.Nullable<int> nit)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nit);
			return ((ISingleResult<buscarProveedoresResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.eliminarProveedores")]
		public int eliminarProveedores([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nit", DbType="Int")] System.Nullable<int> nit)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nit);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertarProveedores")]
		public int insertarProveedores([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nit", DbType="Int")] System.Nullable<int> nit, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Empresa", DbType="VarChar(50)")] string empresa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(50)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="VarChar(50)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Correo", DbType="VarChar(50)")] string correo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nit, empresa, direccion, telefono, correo);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clientes")]
	public partial class Clientes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private string _Nombre;
		
		private string _Direccion;
		
		private string _Telefono;
		
		private string _Correo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    #endregion
		
		public Clientes()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="NVarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NVarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="NVarChar(50)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private string _Nombre;
		
		private string _Contraseña;
		
		private string _Cargo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    partial void OnCargoChanging(string value);
    partial void OnCargoChanged();
    #endregion
		
		public Usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="NVarChar(50)")]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cargo", DbType="NVarChar(50)")]
		public string Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				if ((this._Cargo != value))
				{
					this.OnCargoChanging(value);
					this.SendPropertyChanging();
					this._Cargo = value;
					this.SendPropertyChanged("Cargo");
					this.OnCargoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Productos")]
	public partial class Productos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _ID;
		
		private string _Nombre;
		
		private string _Descripccion;
		
		private System.Nullable<decimal> _ValorUnitario;
		
		private System.Nullable<decimal> _Existencia;
		
		private System.Nullable<decimal> _IDProveedor;
		
		private EntityRef<Proveedores> _Proveedores;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(decimal value);
    partial void OnIDChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDescripccionChanging(string value);
    partial void OnDescripccionChanged();
    partial void OnValorUnitarioChanging(System.Nullable<decimal> value);
    partial void OnValorUnitarioChanged();
    partial void OnExistenciaChanging(System.Nullable<decimal> value);
    partial void OnExistenciaChanged();
    partial void OnIDProveedorChanging(System.Nullable<decimal> value);
    partial void OnIDProveedorChanged();
    #endregion
		
		public Productos()
		{
			this._Proveedores = default(EntityRef<Proveedores>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripccion", DbType="NVarChar(50)")]
		public string Descripccion
		{
			get
			{
				return this._Descripccion;
			}
			set
			{
				if ((this._Descripccion != value))
				{
					this.OnDescripccionChanging(value);
					this.SendPropertyChanging();
					this._Descripccion = value;
					this.SendPropertyChanged("Descripccion");
					this.OnDescripccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValorUnitario", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ValorUnitario
		{
			get
			{
				return this._ValorUnitario;
			}
			set
			{
				if ((this._ValorUnitario != value))
				{
					this.OnValorUnitarioChanging(value);
					this.SendPropertyChanging();
					this._ValorUnitario = value;
					this.SendPropertyChanged("ValorUnitario");
					this.OnValorUnitarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Existencia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Existencia
		{
			get
			{
				return this._Existencia;
			}
			set
			{
				if ((this._Existencia != value))
				{
					this.OnExistenciaChanging(value);
					this.SendPropertyChanging();
					this._Existencia = value;
					this.SendPropertyChanged("Existencia");
					this.OnExistenciaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDProveedor", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> IDProveedor
		{
			get
			{
				return this._IDProveedor;
			}
			set
			{
				if ((this._IDProveedor != value))
				{
					if (this._Proveedores.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDProveedorChanging(value);
					this.SendPropertyChanging();
					this._IDProveedor = value;
					this.SendPropertyChanged("IDProveedor");
					this.OnIDProveedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Proveedores_Productos", Storage="_Proveedores", ThisKey="IDProveedor", OtherKey="Nit", IsForeignKey=true)]
		public Proveedores Proveedores
		{
			get
			{
				return this._Proveedores.Entity;
			}
			set
			{
				Proveedores previousValue = this._Proveedores.Entity;
				if (((previousValue != value) 
							|| (this._Proveedores.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Proveedores.Entity = null;
						previousValue.Productos.Remove(this);
					}
					this._Proveedores.Entity = value;
					if ((value != null))
					{
						value.Productos.Add(this);
						this._IDProveedor = value.Nit;
					}
					else
					{
						this._IDProveedor = default(Nullable<decimal>);
					}
					this.SendPropertyChanged("Proveedores");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Proveedores")]
	public partial class Proveedores : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _Nit;
		
		private string _Empresa;
		
		private string _Direccion;
		
		private string _Telefono;
		
		private string _Correo;
		
		private EntitySet<Productos> _Productos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNitChanging(decimal value);
    partial void OnNitChanged();
    partial void OnEmpresaChanging(string value);
    partial void OnEmpresaChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    #endregion
		
		public Proveedores()
		{
			this._Productos = new EntitySet<Productos>(new Action<Productos>(this.attach_Productos), new Action<Productos>(this.detach_Productos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nit", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal Nit
		{
			get
			{
				return this._Nit;
			}
			set
			{
				if ((this._Nit != value))
				{
					this.OnNitChanging(value);
					this.SendPropertyChanging();
					this._Nit = value;
					this.SendPropertyChanged("Nit");
					this.OnNitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empresa", DbType="NVarChar(50)")]
		public string Empresa
		{
			get
			{
				return this._Empresa;
			}
			set
			{
				if ((this._Empresa != value))
				{
					this.OnEmpresaChanging(value);
					this.SendPropertyChanging();
					this._Empresa = value;
					this.SendPropertyChanged("Empresa");
					this.OnEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="NVarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NVarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="NVarChar(50)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Proveedores_Productos", Storage="_Productos", ThisKey="Nit", OtherKey="IDProveedor")]
		public EntitySet<Productos> Productos
		{
			get
			{
				return this._Productos;
			}
			set
			{
				this._Productos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Productos(Productos entity)
		{
			this.SendPropertyChanging();
			entity.Proveedores = this;
		}
		
		private void detach_Productos(Productos entity)
		{
			this.SendPropertyChanging();
			entity.Proveedores = null;
		}
	}
	
	public partial class buscarClientesResult
	{
		
		private decimal _ID;
		
		private string _Nombre;
		
		private string _Direccion;
		
		private string _Telefono;
		
		private string _Correo;
		
		public buscarClientesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Decimal(18,0) NOT NULL")]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="NVarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NVarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="NVarChar(50)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this._Correo = value;
				}
			}
		}
	}
	
	public partial class buscarUsuariosResult
	{
		
		private decimal _ID;
		
		private string _Nombre;
		
		private string _Contraseña;
		
		private string _Cargo;
		
		public buscarUsuariosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Decimal(18,0) NOT NULL")]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="NVarChar(50)")]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this._Contraseña = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cargo", DbType="NVarChar(50)")]
		public string Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				if ((this._Cargo != value))
				{
					this._Cargo = value;
				}
			}
		}
	}
	
	public partial class buscarProductosResult
	{
		
		private decimal _ID;
		
		private string _Nombre;
		
		private string _Descripccion;
		
		private System.Nullable<decimal> _ValorUnitario;
		
		private System.Nullable<decimal> _Existencia;
		
		private System.Nullable<decimal> _IDProveedor;
		
		public buscarProductosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Decimal(18,0) NOT NULL")]
		public decimal ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripccion", DbType="NVarChar(50)")]
		public string Descripccion
		{
			get
			{
				return this._Descripccion;
			}
			set
			{
				if ((this._Descripccion != value))
				{
					this._Descripccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValorUnitario", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ValorUnitario
		{
			get
			{
				return this._ValorUnitario;
			}
			set
			{
				if ((this._ValorUnitario != value))
				{
					this._ValorUnitario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Existencia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Existencia
		{
			get
			{
				return this._Existencia;
			}
			set
			{
				if ((this._Existencia != value))
				{
					this._Existencia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDProveedor", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> IDProveedor
		{
			get
			{
				return this._IDProveedor;
			}
			set
			{
				if ((this._IDProveedor != value))
				{
					this._IDProveedor = value;
				}
			}
		}
	}
	
	public partial class buscarProveedoresResult
	{
		
		private decimal _Nit;
		
		private string _Empresa;
		
		private string _Direccion;
		
		private string _Telefono;
		
		private string _Correo;
		
		public buscarProveedoresResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nit", DbType="Decimal(18,0) NOT NULL")]
		public decimal Nit
		{
			get
			{
				return this._Nit;
			}
			set
			{
				if ((this._Nit != value))
				{
					this._Nit = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empresa", DbType="NVarChar(50)")]
		public string Empresa
		{
			get
			{
				return this._Empresa;
			}
			set
			{
				if ((this._Empresa != value))
				{
					this._Empresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="NVarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NVarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="NVarChar(50)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this._Correo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
