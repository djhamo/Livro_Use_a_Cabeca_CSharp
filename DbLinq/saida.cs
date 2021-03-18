// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from cdcol on 2014-09-26 17:29:10Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
using System;
using System.ComponentModel;
using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
using System.Diagnostics;


public partial class CdCol : DataContext
{
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
	
	
	public CdCol(string connectionString) : 
			base(connectionString)
	{
		this.OnCreated();
	}
	
	public CdCol(string connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public CdCol(IDbConnection connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Table<CdS> CdS
	{
		get
		{
			return this.GetTable<CdS>();
		}
	}
}

#region Start MONO_STRICT
#if MONO_STRICT

public partial class CdCol
{
	
	public CdCol(IDbConnection connection) : 
			base(connection)
	{
		this.OnCreated();
	}
}
#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT

public partial class CdCol
{
	
	public CdCol(IDbConnection connection) : 
			base(connection, new DbLinq.MySql.MySqlVendor())
	{
		this.OnCreated();
	}
	
	public CdCol(IDbConnection connection, IVendor sqlDialect) : 
			base(connection, sqlDialect)
	{
		this.OnCreated();
	}
	
	public CdCol(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
			base(connection, mappingSource, sqlDialect)
	{
		this.OnCreated();
	}
}
#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
#endregion

[Table(Name="cdcol.cds")]
public partial class CdS : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private long _id;
	
	private string _interpret;
	
	private System.Nullable<int> _jaHR;
	
	private string _tiTel;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnInterpretChanged();
		
		partial void OnInterpretChanging(string value);
		
		partial void OnJAhRChanged();
		
		partial void OnJAhRChanging(System.Nullable<int> value);
		
		partial void OnTItelChanged();
		
		partial void OnTItelChanging(string value);
		#endregion
	
	
	public CdS()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_id", Name="id", DbType="bigint(20) unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public long ID
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((_id != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[Column(Storage="_interpret", Name="interpret", DbType="varchar(200)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Interpret
	{
		get
		{
			return this._interpret;
		}
		set
		{
			if (((_interpret == value) 
						== false))
			{
				this.OnInterpretChanging(value);
				this.SendPropertyChanging();
				this._interpret = value;
				this.SendPropertyChanged("Interpret");
				this.OnInterpretChanged();
			}
		}
	}
	
	[Column(Storage="_jaHR", Name="jahr", DbType="int", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> JAhR
	{
		get
		{
			return this._jaHR;
		}
		set
		{
			if ((_jaHR != value))
			{
				this.OnJAhRChanging(value);
				this.SendPropertyChanging();
				this._jaHR = value;
				this.SendPropertyChanged("JAhR");
				this.OnJAhRChanged();
			}
		}
	}
	
	[Column(Storage="_tiTel", Name="titel", DbType="varchar(200)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string TItel
	{
		get
		{
			return this._tiTel;
		}
		set
		{
			if (((_tiTel == value) 
						== false))
			{
				this.OnTItelChanging(value);
				this.SendPropertyChanging();
				this._tiTel = value;
				this.SendPropertyChanged("TItel");
				this.OnTItelChanged();
			}
		}
	}
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
}
