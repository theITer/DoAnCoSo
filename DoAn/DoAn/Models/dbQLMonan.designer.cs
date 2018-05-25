﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLMonan")]
	public partial class dbQLMonanDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void UpdateCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void DeleteCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void InsertCTMONAN(CTMONAN instance);
    partial void UpdateCTMONAN(CTMONAN instance);
    partial void DeleteCTMONAN(CTMONAN instance);
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertLOAIMON(LOAIMON instance);
    partial void UpdateLOAIMON(LOAIMON instance);
    partial void DeleteLOAIMON(LOAIMON instance);
    partial void InsertTb_Drink(Tb_Drink instance);
    partial void UpdateTb_Drink(Tb_Drink instance);
    partial void DeleteTb_Drink(Tb_Drink instance);
    #endregion
		
		public dbQLMonanDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLMonanConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLMonanDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLMonanDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLMonanDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLMonanDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this.GetTable<CHITIETDONTHANG>();
			}
		}
		
		public System.Data.Linq.Table<CTMONAN> CTMONANs
		{
			get
			{
				return this.GetTable<CTMONAN>();
			}
		}
		
		public System.Data.Linq.Table<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this.GetTable<DONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<LOAIMON> LOAIMONs
		{
			get
			{
				return this.GetTable<LOAIMON>();
			}
		}
		
		public System.Data.Linq.Table<Tb_Drink> Tb_Drinks
		{
			get
			{
				return this.GetTable<Tb_Drink>();
			}
		}
		
		public System.Data.Linq.Table<HOTDISH> HOTDISHes
		{
			get
			{
				return this.GetTable<HOTDISH>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONTHANG")]
	public partial class CHITIETDONTHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private int _Mamon;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<decimal> _Dongia;
		
		private int _MaThucUong;
		
		private EntityRef<CTMONAN> _CTMONAN;
		
		private EntityRef<DONDATHANG> _DONDATHANG;
		
		private EntityRef<Tb_Drink> _Tb_Drink;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnMamonChanging(int value);
    partial void OnMamonChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnDongiaChanging(System.Nullable<decimal> value);
    partial void OnDongiaChanged();
    partial void OnMaThucUongChanging(int value);
    partial void OnMaThucUongChanged();
    #endregion
		
		public CHITIETDONTHANG()
		{
			this._CTMONAN = default(EntityRef<CTMONAN>);
			this._DONDATHANG = default(EntityRef<DONDATHANG>);
			this._Tb_Drink = default(EntityRef<Tb_Drink>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					if (this._DONDATHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mamon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Mamon
		{
			get
			{
				return this._Mamon;
			}
			set
			{
				if ((this._Mamon != value))
				{
					if (this._CTMONAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMamonChanging(value);
					this.SendPropertyChanging();
					this._Mamon = value;
					this.SendPropertyChanged("Mamon");
					this.OnMamonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Dongia
		{
			get
			{
				return this._Dongia;
			}
			set
			{
				if ((this._Dongia != value))
				{
					this.OnDongiaChanging(value);
					this.SendPropertyChanging();
					this._Dongia = value;
					this.SendPropertyChanged("Dongia");
					this.OnDongiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThucUong", DbType="Int NOT NULL")]
		public int MaThucUong
		{
			get
			{
				return this._MaThucUong;
			}
			set
			{
				if ((this._MaThucUong != value))
				{
					if (this._Tb_Drink.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaThucUongChanging(value);
					this.SendPropertyChanging();
					this._MaThucUong = value;
					this.SendPropertyChanged("MaThucUong");
					this.OnMaThucUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CTMONAN_CHITIETDONTHANG", Storage="_CTMONAN", ThisKey="Mamon", OtherKey="Mamon", IsForeignKey=true)]
		public CTMONAN CTMONAN
		{
			get
			{
				return this._CTMONAN.Entity;
			}
			set
			{
				CTMONAN previousValue = this._CTMONAN.Entity;
				if (((previousValue != value) 
							|| (this._CTMONAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CTMONAN.Entity = null;
						previousValue.CHITIETDONTHANGs.Remove(this);
					}
					this._CTMONAN.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONTHANGs.Add(this);
						this._Mamon = value.Mamon;
					}
					else
					{
						this._Mamon = default(int);
					}
					this.SendPropertyChanged("CTMONAN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CHITIETDONTHANG", Storage="_DONDATHANG", ThisKey="MaDonHang", OtherKey="MaDonHang", IsForeignKey=true)]
		public DONDATHANG DONDATHANG
		{
			get
			{
				return this._DONDATHANG.Entity;
			}
			set
			{
				DONDATHANG previousValue = this._DONDATHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONDATHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONDATHANG.Entity = null;
						previousValue.CHITIETDONTHANGs.Remove(this);
					}
					this._DONDATHANG.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONTHANGs.Add(this);
						this._MaDonHang = value.MaDonHang;
					}
					else
					{
						this._MaDonHang = default(int);
					}
					this.SendPropertyChanged("DONDATHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tb_Drink_CHITIETDONTHANG", Storage="_Tb_Drink", ThisKey="MaThucUong", OtherKey="MaThucUong", IsForeignKey=true)]
		public Tb_Drink Tb_Drink
		{
			get
			{
				return this._Tb_Drink.Entity;
			}
			set
			{
				Tb_Drink previousValue = this._Tb_Drink.Entity;
				if (((previousValue != value) 
							|| (this._Tb_Drink.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tb_Drink.Entity = null;
						previousValue.CHITIETDONTHANGs.Remove(this);
					}
					this._Tb_Drink.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONTHANGs.Add(this);
						this._MaThucUong = value.MaThucUong;
					}
					else
					{
						this._MaThucUong = default(int);
					}
					this.SendPropertyChanged("Tb_Drink");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTMONAN")]
	public partial class CTMONAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Mamon;
		
		private string _Tenmon;
		
		private System.Nullable<decimal> _Giaban;
		
		private string _Anh;
		
		private string _Trangthai;
		
		private string _Mota;
		
		private System.Nullable<int> _Maloai;
		
		private EntitySet<CHITIETDONTHANG> _CHITIETDONTHANGs;
		
		private EntityRef<LOAIMON> _LOAIMON;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMamonChanging(int value);
    partial void OnMamonChanged();
    partial void OnTenmonChanging(string value);
    partial void OnTenmonChanged();
    partial void OnGiabanChanging(System.Nullable<decimal> value);
    partial void OnGiabanChanged();
    partial void OnAnhChanging(string value);
    partial void OnAnhChanged();
    partial void OnTrangthaiChanging(string value);
    partial void OnTrangthaiChanged();
    partial void OnMotaChanging(string value);
    partial void OnMotaChanged();
    partial void OnMaloaiChanging(System.Nullable<int> value);
    partial void OnMaloaiChanged();
    #endregion
		
		public CTMONAN()
		{
			this._CHITIETDONTHANGs = new EntitySet<CHITIETDONTHANG>(new Action<CHITIETDONTHANG>(this.attach_CHITIETDONTHANGs), new Action<CHITIETDONTHANG>(this.detach_CHITIETDONTHANGs));
			this._LOAIMON = default(EntityRef<LOAIMON>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mamon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Mamon
		{
			get
			{
				return this._Mamon;
			}
			set
			{
				if ((this._Mamon != value))
				{
					this.OnMamonChanging(value);
					this.SendPropertyChanging();
					this._Mamon = value;
					this.SendPropertyChanged("Mamon");
					this.OnMamonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenmon", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Tenmon
		{
			get
			{
				return this._Tenmon;
			}
			set
			{
				if ((this._Tenmon != value))
				{
					this.OnTenmonChanging(value);
					this.SendPropertyChanging();
					this._Tenmon = value;
					this.SendPropertyChanged("Tenmon");
					this.OnTenmonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Giaban", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Giaban
		{
			get
			{
				return this._Giaban;
			}
			set
			{
				if ((this._Giaban != value))
				{
					this.OnGiabanChanging(value);
					this.SendPropertyChanging();
					this._Giaban = value;
					this.SendPropertyChanged("Giaban");
					this.OnGiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anh", DbType="VarChar(50)")]
		public string Anh
		{
			get
			{
				return this._Anh;
			}
			set
			{
				if ((this._Anh != value))
				{
					this.OnAnhChanging(value);
					this.SendPropertyChanging();
					this._Anh = value;
					this.SendPropertyChanged("Anh");
					this.OnAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Trangthai", DbType="NVarChar(10)")]
		public string Trangthai
		{
			get
			{
				return this._Trangthai;
			}
			set
			{
				if ((this._Trangthai != value))
				{
					this.OnTrangthaiChanging(value);
					this.SendPropertyChanging();
					this._Trangthai = value;
					this.SendPropertyChanged("Trangthai");
					this.OnTrangthaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mota", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Mota
		{
			get
			{
				return this._Mota;
			}
			set
			{
				if ((this._Mota != value))
				{
					this.OnMotaChanging(value);
					this.SendPropertyChanging();
					this._Mota = value;
					this.SendPropertyChanged("Mota");
					this.OnMotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maloai", DbType="Int")]
		public System.Nullable<int> Maloai
		{
			get
			{
				return this._Maloai;
			}
			set
			{
				if ((this._Maloai != value))
				{
					if (this._LOAIMON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaloaiChanging(value);
					this.SendPropertyChanging();
					this._Maloai = value;
					this.SendPropertyChanged("Maloai");
					this.OnMaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CTMONAN_CHITIETDONTHANG", Storage="_CHITIETDONTHANGs", ThisKey="Mamon", OtherKey="Mamon")]
		public EntitySet<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this._CHITIETDONTHANGs;
			}
			set
			{
				this._CHITIETDONTHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAIMON_CTMONAN", Storage="_LOAIMON", ThisKey="Maloai", OtherKey="Maloai", IsForeignKey=true)]
		public LOAIMON LOAIMON
		{
			get
			{
				return this._LOAIMON.Entity;
			}
			set
			{
				LOAIMON previousValue = this._LOAIMON.Entity;
				if (((previousValue != value) 
							|| (this._LOAIMON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAIMON.Entity = null;
						previousValue.CTMONANs.Remove(this);
					}
					this._LOAIMON.Entity = value;
					if ((value != null))
					{
						value.CTMONANs.Add(this);
						this._Maloai = value.Maloai;
					}
					else
					{
						this._Maloai = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAIMON");
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
		
		private void attach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.CTMONAN = this;
		}
		
		private void detach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.CTMONAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private System.Nullable<bool> _Dathanhtoan;
		
		private System.Nullable<bool> _Tinhtranggiaohang;
		
		private System.Nullable<System.DateTime> _Ngaydat;
		
		private System.Nullable<int> _MaKH;
		
		private EntitySet<CHITIETDONTHANG> _CHITIETDONTHANGs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnDathanhtoanChanging(System.Nullable<bool> value);
    partial void OnDathanhtoanChanged();
    partial void OnTinhtranggiaohangChanging(System.Nullable<bool> value);
    partial void OnTinhtranggiaohangChanged();
    partial void OnNgaydatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaydatChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    #endregion
		
		public DONDATHANG()
		{
			this._CHITIETDONTHANGs = new EntitySet<CHITIETDONTHANG>(new Action<CHITIETDONTHANG>(this.attach_CHITIETDONTHANGs), new Action<CHITIETDONTHANG>(this.detach_CHITIETDONTHANGs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dathanhtoan", DbType="Bit")]
		public System.Nullable<bool> Dathanhtoan
		{
			get
			{
				return this._Dathanhtoan;
			}
			set
			{
				if ((this._Dathanhtoan != value))
				{
					this.OnDathanhtoanChanging(value);
					this.SendPropertyChanging();
					this._Dathanhtoan = value;
					this.SendPropertyChanged("Dathanhtoan");
					this.OnDathanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tinhtranggiaohang", DbType="Bit")]
		public System.Nullable<bool> Tinhtranggiaohang
		{
			get
			{
				return this._Tinhtranggiaohang;
			}
			set
			{
				if ((this._Tinhtranggiaohang != value))
				{
					this.OnTinhtranggiaohangChanging(value);
					this.SendPropertyChanging();
					this._Tinhtranggiaohang = value;
					this.SendPropertyChanged("Tinhtranggiaohang");
					this.OnTinhtranggiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaydat", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaydat
		{
			get
			{
				return this._Ngaydat;
			}
			set
			{
				if ((this._Ngaydat != value))
				{
					this.OnNgaydatChanging(value);
					this.SendPropertyChanging();
					this._Ngaydat = value;
					this.SendPropertyChanged("Ngaydat");
					this.OnNgaydatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CHITIETDONTHANG", Storage="_CHITIETDONTHANGs", ThisKey="MaDonHang", OtherKey="MaDonHang")]
		public EntitySet<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this._CHITIETDONTHANGs;
			}
			set
			{
				this._CHITIETDONTHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONDATHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONDATHANGs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
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
		
		private void attach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = this;
		}
		
		private void detach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTen;
		
		private string _Taikhoan;
		
		private string _Matkhau;
		
		private string _Email;
		
		private string _Diachi;
		
		private string _Dienthoai;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
		private EntitySet<DONDATHANG> _DONDATHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnTaikhoanChanging(string value);
    partial void OnTaikhoanChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiachiChanging(string value);
    partial void OnDiachiChanged();
    partial void OnDienthoaiChanging(string value);
    partial void OnDienthoaiChanged();
    partial void OnNgaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaysinhChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONDATHANGs = new EntitySet<DONDATHANG>(new Action<DONDATHANG>(this.attach_DONDATHANGs), new Action<DONDATHANG>(this.detach_DONDATHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taikhoan", DbType="VarChar(50)")]
		public string Taikhoan
		{
			get
			{
				return this._Taikhoan;
			}
			set
			{
				if ((this._Taikhoan != value))
				{
					this.OnTaikhoanChanging(value);
					this.SendPropertyChanging();
					this._Taikhoan = value;
					this.SendPropertyChanged("Taikhoan");
					this.OnTaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="NVarChar(200)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this.OnDiachiChanging(value);
					this.SendPropertyChanging();
					this._Diachi = value;
					this.SendPropertyChanged("Diachi");
					this.OnDiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dienthoai", DbType="VarChar(50)")]
		public string Dienthoai
		{
			get
			{
				return this._Dienthoai;
			}
			set
			{
				if ((this._Dienthoai != value))
				{
					this.OnDienthoaiChanging(value);
					this.SendPropertyChanging();
					this._Dienthoai = value;
					this.SendPropertyChanged("Dienthoai");
					this.OnDienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this.OnNgaysinhChanging(value);
					this.SendPropertyChanging();
					this._Ngaysinh = value;
					this.SendPropertyChanged("Ngaysinh");
					this.OnNgaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_DONDATHANGs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this._DONDATHANGs;
			}
			set
			{
				this._DONDATHANGs.Assign(value);
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
		
		private void attach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAIMON")]
	public partial class LOAIMON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Maloai;
		
		private string _Tenloai;
		
		private EntitySet<CTMONAN> _CTMONANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaloaiChanging(int value);
    partial void OnMaloaiChanged();
    partial void OnTenloaiChanging(string value);
    partial void OnTenloaiChanged();
    #endregion
		
		public LOAIMON()
		{
			this._CTMONANs = new EntitySet<CTMONAN>(new Action<CTMONAN>(this.attach_CTMONANs), new Action<CTMONAN>(this.detach_CTMONANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maloai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Maloai
		{
			get
			{
				return this._Maloai;
			}
			set
			{
				if ((this._Maloai != value))
				{
					this.OnMaloaiChanging(value);
					this.SendPropertyChanging();
					this._Maloai = value;
					this.SendPropertyChanged("Maloai");
					this.OnMaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenloai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Tenloai
		{
			get
			{
				return this._Tenloai;
			}
			set
			{
				if ((this._Tenloai != value))
				{
					this.OnTenloaiChanging(value);
					this.SendPropertyChanging();
					this._Tenloai = value;
					this.SendPropertyChanged("Tenloai");
					this.OnTenloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAIMON_CTMONAN", Storage="_CTMONANs", ThisKey="Maloai", OtherKey="Maloai")]
		public EntitySet<CTMONAN> CTMONANs
		{
			get
			{
				return this._CTMONANs;
			}
			set
			{
				this._CTMONANs.Assign(value);
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
		
		private void attach_CTMONANs(CTMONAN entity)
		{
			this.SendPropertyChanging();
			entity.LOAIMON = this;
		}
		
		private void detach_CTMONANs(CTMONAN entity)
		{
			this.SendPropertyChanging();
			entity.LOAIMON = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tb_Drinks")]
	public partial class Tb_Drink : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaThucUong;
		
		private string _TenThucUong;
		
		private System.Nullable<decimal> _GiaBan;
		
		private EntitySet<CHITIETDONTHANG> _CHITIETDONTHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaThucUongChanging(int value);
    partial void OnMaThucUongChanged();
    partial void OnTenThucUongChanging(string value);
    partial void OnTenThucUongChanged();
    partial void OnGiaBanChanging(System.Nullable<decimal> value);
    partial void OnGiaBanChanged();
    #endregion
		
		public Tb_Drink()
		{
			this._CHITIETDONTHANGs = new EntitySet<CHITIETDONTHANG>(new Action<CHITIETDONTHANG>(this.attach_CHITIETDONTHANGs), new Action<CHITIETDONTHANG>(this.detach_CHITIETDONTHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThucUong", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaThucUong
		{
			get
			{
				return this._MaThucUong;
			}
			set
			{
				if ((this._MaThucUong != value))
				{
					this.OnMaThucUongChanging(value);
					this.SendPropertyChanging();
					this._MaThucUong = value;
					this.SendPropertyChanged("MaThucUong");
					this.OnMaThucUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenThucUong", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string TenThucUong
		{
			get
			{
				return this._TenThucUong;
			}
			set
			{
				if ((this._TenThucUong != value))
				{
					this.OnTenThucUongChanging(value);
					this.SendPropertyChanging();
					this._TenThucUong = value;
					this.SendPropertyChanged("TenThucUong");
					this.OnTenThucUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this.OnGiaBanChanging(value);
					this.SendPropertyChanging();
					this._GiaBan = value;
					this.SendPropertyChanged("GiaBan");
					this.OnGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tb_Drink_CHITIETDONTHANG", Storage="_CHITIETDONTHANGs", ThisKey="MaThucUong", OtherKey="MaThucUong")]
		public EntitySet<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this._CHITIETDONTHANGs;
			}
			set
			{
				this._CHITIETDONTHANGs.Assign(value);
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
		
		private void attach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.Tb_Drink = this;
		}
		
		private void detach_CHITIETDONTHANGs(CHITIETDONTHANG entity)
		{
			this.SendPropertyChanging();
			entity.Tb_Drink = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOTDISH")]
	public partial class HOTDISH
	{
		
		private int _Mamon;
		
		private string _Tenmon;
		
		private System.Nullable<decimal> _GIABAN;
		
		private string _ANH;
		
		private System.Nullable<int> _SOLUONGMUA;
		
		public HOTDISH()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mamon", DbType="Int NOT NULL")]
		public int Mamon
		{
			get
			{
				return this._Mamon;
			}
			set
			{
				if ((this._Mamon != value))
				{
					this._Mamon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenmon", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Tenmon
		{
			get
			{
				return this._Tenmon;
			}
			set
			{
				if ((this._Tenmon != value))
				{
					this._Tenmon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIABAN", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> GIABAN
		{
			get
			{
				return this._GIABAN;
			}
			set
			{
				if ((this._GIABAN != value))
				{
					this._GIABAN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ANH", DbType="VarChar(50)")]
		public string ANH
		{
			get
			{
				return this._ANH;
			}
			set
			{
				if ((this._ANH != value))
				{
					this._ANH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONGMUA", DbType="Int")]
		public System.Nullable<int> SOLUONGMUA
		{
			get
			{
				return this._SOLUONGMUA;
			}
			set
			{
				if ((this._SOLUONGMUA != value))
				{
					this._SOLUONGMUA = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
