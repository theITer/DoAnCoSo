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
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertLOAI(LOAI instance);
    partial void UpdateLOAI(LOAI instance);
    partial void DeleteLOAI(LOAI instance);
    partial void InsertMONAN(MONAN instance);
    partial void UpdateMONAN(MONAN instance);
    partial void DeleteMONAN(MONAN instance);
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
		
		public System.Data.Linq.Table<LOAI> LOAIs
		{
			get
			{
				return this.GetTable<LOAI>();
			}
		}
		
		public System.Data.Linq.Table<MONAN> MONANs
		{
			get
			{
				return this.GetTable<MONAN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONTHANG")]
	public partial class CHITIETDONTHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private int _Masach;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<decimal> _Dongia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnMasachChanging(int value);
    partial void OnMasachChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnDongiaChanging(System.Nullable<decimal> value);
    partial void OnDongiaChanged();
    #endregion
		
		public CHITIETDONTHANG()
		{
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
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Masach", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Masach
		{
			get
			{
				return this._Masach;
			}
			set
			{
				if ((this._Masach != value))
				{
					this.OnMasachChanging(value);
					this.SendPropertyChanging();
					this._Masach = value;
					this.SendPropertyChanged("Masach");
					this.OnMasachChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private System.Nullable<bool> _Dathanhtoan;
		
		private System.Nullable<bool> _Tinhtranggiaohang;
		
		private System.Nullable<System.DateTime> _Ngaydat;
		
		private System.Nullable<System.DateTime> _Ngaygiao;
		
		private System.Nullable<int> _MaKH;
		
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
    partial void OnNgaygiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaygiaoChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    #endregion
		
		public DONDATHANG()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaygiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaygiao
		{
			get
			{
				return this._Ngaygiao;
			}
			set
			{
				if ((this._Ngaygiao != value))
				{
					this.OnNgaygiaoChanging(value);
					this.SendPropertyChanging();
					this._Ngaygiao = value;
					this.SendPropertyChanged("Ngaygiao");
					this.OnNgaygiaoChanged();
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
		
		private string _DiachiKH;
		
		private string _DienthoaiKH;
		
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
    partial void OnDiachiKHChanging(string value);
    partial void OnDiachiKHChanged();
    partial void OnDienthoaiKHChanging(string value);
    partial void OnDienthoaiKHChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiachiKH", DbType="NVarChar(200)")]
		public string DiachiKH
		{
			get
			{
				return this._DiachiKH;
			}
			set
			{
				if ((this._DiachiKH != value))
				{
					this.OnDiachiKHChanging(value);
					this.SendPropertyChanging();
					this._DiachiKH = value;
					this.SendPropertyChanged("DiachiKH");
					this.OnDiachiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienthoaiKH", DbType="VarChar(50)")]
		public string DienthoaiKH
		{
			get
			{
				return this._DienthoaiKH;
			}
			set
			{
				if ((this._DienthoaiKH != value))
				{
					this.OnDienthoaiKHChanging(value);
					this.SendPropertyChanging();
					this._DienthoaiKH = value;
					this.SendPropertyChanged("DienthoaiKH");
					this.OnDienthoaiKHChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAI")]
	public partial class LOAI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Maloai;
		
		private string _Tenloai;
		
		private EntitySet<MONAN> _MONANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaloaiChanging(int value);
    partial void OnMaloaiChanged();
    partial void OnTenloaiChanging(string value);
    partial void OnTenloaiChanged();
    #endregion
		
		public LOAI()
		{
			this._MONANs = new EntitySet<MONAN>(new Action<MONAN>(this.attach_MONANs), new Action<MONAN>(this.detach_MONANs));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_MONAN", Storage="_MONANs", ThisKey="Maloai", OtherKey="Maloai")]
		public EntitySet<MONAN> MONANs
		{
			get
			{
				return this._MONANs;
			}
			set
			{
				this._MONANs.Assign(value);
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
		
		private void attach_MONANs(MONAN entity)
		{
			this.SendPropertyChanging();
			entity.LOAI = this;
		}
		
		private void detach_MONANs(MONAN entity)
		{
			this.SendPropertyChanging();
			entity.LOAI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MONAN")]
	public partial class MONAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Mamon;
		
		private string _Tenmon;
		
		private System.Nullable<decimal> _Giaban;
		
		private System.Nullable<int> _Soluong;
		
		private string _Anh;
		
		private string _Trangthai;
		
		private string _Thucuong;
		
		private System.Nullable<int> _Maloai;
		
		private EntityRef<LOAI> _LOAI;
		
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
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnAnhChanging(string value);
    partial void OnAnhChanged();
    partial void OnTrangthaiChanging(string value);
    partial void OnTrangthaiChanged();
    partial void OnThucuongChanging(string value);
    partial void OnThucuongChanged();
    partial void OnMaloaiChanging(System.Nullable<int> value);
    partial void OnMaloaiChanged();
    #endregion
		
		public MONAN()
		{
			this._LOAI = default(EntityRef<LOAI>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thucuong", DbType="NVarChar(10)")]
		public string Thucuong
		{
			get
			{
				return this._Thucuong;
			}
			set
			{
				if ((this._Thucuong != value))
				{
					this.OnThucuongChanging(value);
					this.SendPropertyChanging();
					this._Thucuong = value;
					this.SendPropertyChanged("Thucuong");
					this.OnThucuongChanged();
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
					if (this._LOAI.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_MONAN", Storage="_LOAI", ThisKey="Maloai", OtherKey="Maloai", IsForeignKey=true)]
		public LOAI LOAI
		{
			get
			{
				return this._LOAI.Entity;
			}
			set
			{
				LOAI previousValue = this._LOAI.Entity;
				if (((previousValue != value) 
							|| (this._LOAI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAI.Entity = null;
						previousValue.MONANs.Remove(this);
					}
					this._LOAI.Entity = value;
					if ((value != null))
					{
						value.MONANs.Add(this);
						this._Maloai = value.Maloai;
					}
					else
					{
						this._Maloai = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAI");
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
}
#pragma warning restore 1591
