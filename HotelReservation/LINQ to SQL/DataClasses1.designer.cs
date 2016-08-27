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

namespace LINQ_to_SQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HotelReservation")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBookingDetail(BookingDetail instance);
    partial void UpdateBookingDetail(BookingDetail instance);
    partial void DeleteBookingDetail(BookingDetail instance);
    partial void InsertCitiesDetail(CitiesDetail instance);
    partial void UpdateCitiesDetail(CitiesDetail instance);
    partial void DeleteCitiesDetail(CitiesDetail instance);
    partial void InsertCustomerData(CustomerData instance);
    partial void UpdateCustomerData(CustomerData instance);
    partial void DeleteCustomerData(CustomerData instance);
    partial void InsertHotel_Data(Hotel_Data instance);
    partial void UpdateHotel_Data(Hotel_Data instance);
    partial void DeleteHotel_Data(Hotel_Data instance);
    partial void InsertHotelRoom(HotelRoom instance);
    partial void UpdateHotelRoom(HotelRoom instance);
    partial void DeleteHotelRoom(HotelRoom instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LINQ_to_SQL.Properties.Settings.Default.HotelReservationConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BookingDetail> BookingDetails
		{
			get
			{
				return this.GetTable<BookingDetail>();
			}
		}
		
		public System.Data.Linq.Table<CitiesDetail> CitiesDetails
		{
			get
			{
				return this.GetTable<CitiesDetail>();
			}
		}
		
		public System.Data.Linq.Table<CustomerData> CustomerDatas
		{
			get
			{
				return this.GetTable<CustomerData>();
			}
		}
		
		public System.Data.Linq.Table<Hotel_Data> Hotel_Datas
		{
			get
			{
				return this.GetTable<Hotel_Data>();
			}
		}
		
		public System.Data.Linq.Table<HotelRoom> HotelRooms
		{
			get
			{
				return this.GetTable<HotelRoom>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookingDetails")]
	public partial class BookingDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Booking_Id;
		
		private long _Cust_Id;
		
		private long _Hotel_Id;
		
		private System.Nullable<System.DateTime> _CheckInDate;
		
		private System.Nullable<System.DateTime> _CheckOutDate;
		
		private EntityRef<CustomerData> _CustomerData;
		
		private EntityRef<Hotel_Data> _Hotel_Data;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBooking_IdChanging(long value);
    partial void OnBooking_IdChanged();
    partial void OnCust_IdChanging(long value);
    partial void OnCust_IdChanged();
    partial void OnHotel_IdChanging(long value);
    partial void OnHotel_IdChanged();
    partial void OnCheckInDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCheckInDateChanged();
    partial void OnCheckOutDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCheckOutDateChanged();
    #endregion
		
		public BookingDetail()
		{
			this._CustomerData = default(EntityRef<CustomerData>);
			this._Hotel_Data = default(EntityRef<Hotel_Data>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Booking_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Booking_Id
		{
			get
			{
				return this._Booking_Id;
			}
			set
			{
				if ((this._Booking_Id != value))
				{
					this.OnBooking_IdChanging(value);
					this.SendPropertyChanging();
					this._Booking_Id = value;
					this.SendPropertyChanged("Booking_Id");
					this.OnBooking_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cust_Id", DbType="BigInt NOT NULL")]
		public long Cust_Id
		{
			get
			{
				return this._Cust_Id;
			}
			set
			{
				if ((this._Cust_Id != value))
				{
					if (this._CustomerData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCust_IdChanging(value);
					this.SendPropertyChanging();
					this._Cust_Id = value;
					this.SendPropertyChanged("Cust_Id");
					this.OnCust_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotel_Id", DbType="BigInt NOT NULL")]
		public long Hotel_Id
		{
			get
			{
				return this._Hotel_Id;
			}
			set
			{
				if ((this._Hotel_Id != value))
				{
					if (this._Hotel_Data.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHotel_IdChanging(value);
					this.SendPropertyChanging();
					this._Hotel_Id = value;
					this.SendPropertyChanged("Hotel_Id");
					this.OnHotel_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckInDate", DbType="Date")]
		public System.Nullable<System.DateTime> CheckInDate
		{
			get
			{
				return this._CheckInDate;
			}
			set
			{
				if ((this._CheckInDate != value))
				{
					this.OnCheckInDateChanging(value);
					this.SendPropertyChanging();
					this._CheckInDate = value;
					this.SendPropertyChanged("CheckInDate");
					this.OnCheckInDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckOutDate", DbType="Date")]
		public System.Nullable<System.DateTime> CheckOutDate
		{
			get
			{
				return this._CheckOutDate;
			}
			set
			{
				if ((this._CheckOutDate != value))
				{
					this.OnCheckOutDateChanging(value);
					this.SendPropertyChanging();
					this._CheckOutDate = value;
					this.SendPropertyChanged("CheckOutDate");
					this.OnCheckOutDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerData_BookingDetail", Storage="_CustomerData", ThisKey="Cust_Id", OtherKey="Cust_Id", IsForeignKey=true)]
		public CustomerData CustomerData
		{
			get
			{
				return this._CustomerData.Entity;
			}
			set
			{
				CustomerData previousValue = this._CustomerData.Entity;
				if (((previousValue != value) 
							|| (this._CustomerData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CustomerData.Entity = null;
						previousValue.BookingDetails.Remove(this);
					}
					this._CustomerData.Entity = value;
					if ((value != null))
					{
						value.BookingDetails.Add(this);
						this._Cust_Id = value.Cust_Id;
					}
					else
					{
						this._Cust_Id = default(long);
					}
					this.SendPropertyChanged("CustomerData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Data_BookingDetail", Storage="_Hotel_Data", ThisKey="Hotel_Id", OtherKey="Hotel_Id", IsForeignKey=true)]
		public Hotel_Data Hotel_Data
		{
			get
			{
				return this._Hotel_Data.Entity;
			}
			set
			{
				Hotel_Data previousValue = this._Hotel_Data.Entity;
				if (((previousValue != value) 
							|| (this._Hotel_Data.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Hotel_Data.Entity = null;
						previousValue.BookingDetails.Remove(this);
					}
					this._Hotel_Data.Entity = value;
					if ((value != null))
					{
						value.BookingDetails.Add(this);
						this._Hotel_Id = value.Hotel_Id;
					}
					else
					{
						this._Hotel_Id = default(long);
					}
					this.SendPropertyChanged("Hotel_Data");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CitiesDetails")]
	public partial class CitiesDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _CityCode;
		
		private string _CityName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCityCodeChanging(long value);
    partial void OnCityCodeChanged();
    partial void OnCityNameChanging(string value);
    partial void OnCityNameChanged();
    #endregion
		
		public CitiesDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityCode", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long CityCode
		{
			get
			{
				return this._CityCode;
			}
			set
			{
				if ((this._CityCode != value))
				{
					this.OnCityCodeChanging(value);
					this.SendPropertyChanging();
					this._CityCode = value;
					this.SendPropertyChanged("CityCode");
					this.OnCityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this.OnCityNameChanging(value);
					this.SendPropertyChanging();
					this._CityName = value;
					this.SendPropertyChanged("CityName");
					this.OnCityNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerData")]
	public partial class CustomerData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Cust_Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _EmailId;
		
		private string _PhoneNumber;
		
		private EntitySet<BookingDetail> _BookingDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCust_IdChanging(long value);
    partial void OnCust_IdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailIdChanging(string value);
    partial void OnEmailIdChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    #endregion
		
		public CustomerData()
		{
			this._BookingDetails = new EntitySet<BookingDetail>(new Action<BookingDetail>(this.attach_BookingDetails), new Action<BookingDetail>(this.detach_BookingDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cust_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Cust_Id
		{
			get
			{
				return this._Cust_Id;
			}
			set
			{
				if ((this._Cust_Id != value))
				{
					this.OnCust_IdChanging(value);
					this.SendPropertyChanging();
					this._Cust_Id = value;
					this.SendPropertyChanged("Cust_Id");
					this.OnCust_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="NVarChar(20)")]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this.OnEmailIdChanging(value);
					this.SendPropertyChanging();
					this._EmailId = value;
					this.SendPropertyChanged("EmailId");
					this.OnEmailIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NChar(10)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerData_BookingDetail", Storage="_BookingDetails", ThisKey="Cust_Id", OtherKey="Cust_Id")]
		public EntitySet<BookingDetail> BookingDetails
		{
			get
			{
				return this._BookingDetails;
			}
			set
			{
				this._BookingDetails.Assign(value);
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
		
		private void attach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.CustomerData = this;
		}
		
		private void detach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.CustomerData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hotel_Data")]
	public partial class Hotel_Data : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Hotel_Id;
		
		private string _HotelName;
		
		private string _HotelEmailID;
		
		private string _HotelPhoneNumber;
		
		private string _City;
		
		private EntitySet<BookingDetail> _BookingDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHotel_IdChanging(long value);
    partial void OnHotel_IdChanged();
    partial void OnHotelNameChanging(string value);
    partial void OnHotelNameChanged();
    partial void OnHotelEmailIDChanging(string value);
    partial void OnHotelEmailIDChanged();
    partial void OnHotelPhoneNumberChanging(string value);
    partial void OnHotelPhoneNumberChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    #endregion
		
		public Hotel_Data()
		{
			this._BookingDetails = new EntitySet<BookingDetail>(new Action<BookingDetail>(this.attach_BookingDetails), new Action<BookingDetail>(this.detach_BookingDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotel_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Hotel_Id
		{
			get
			{
				return this._Hotel_Id;
			}
			set
			{
				if ((this._Hotel_Id != value))
				{
					this.OnHotel_IdChanging(value);
					this.SendPropertyChanging();
					this._Hotel_Id = value;
					this.SendPropertyChanged("Hotel_Id");
					this.OnHotel_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelName", DbType="NVarChar(50)")]
		public string HotelName
		{
			get
			{
				return this._HotelName;
			}
			set
			{
				if ((this._HotelName != value))
				{
					this.OnHotelNameChanging(value);
					this.SendPropertyChanging();
					this._HotelName = value;
					this.SendPropertyChanged("HotelName");
					this.OnHotelNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelEmailID", DbType="NVarChar(50)")]
		public string HotelEmailID
		{
			get
			{
				return this._HotelEmailID;
			}
			set
			{
				if ((this._HotelEmailID != value))
				{
					this.OnHotelEmailIDChanging(value);
					this.SendPropertyChanging();
					this._HotelEmailID = value;
					this.SendPropertyChanged("HotelEmailID");
					this.OnHotelEmailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelPhoneNumber", DbType="NVarChar(10)")]
		public string HotelPhoneNumber
		{
			get
			{
				return this._HotelPhoneNumber;
			}
			set
			{
				if ((this._HotelPhoneNumber != value))
				{
					this.OnHotelPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._HotelPhoneNumber = value;
					this.SendPropertyChanged("HotelPhoneNumber");
					this.OnHotelPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Data_BookingDetail", Storage="_BookingDetails", ThisKey="Hotel_Id", OtherKey="Hotel_Id")]
		public EntitySet<BookingDetail> BookingDetails
		{
			get
			{
				return this._BookingDetails;
			}
			set
			{
				this._BookingDetails.Assign(value);
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
		
		private void attach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.Hotel_Data = this;
		}
		
		private void detach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.Hotel_Data = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HotelRooms")]
	public partial class HotelRoom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Room_Id;
		
		private long _Hotel_Id;
		
		private string _RoomType;
		
		private long _Rates;
		
		private long _AvailableRooms;
		
		private long _TotalRooms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoom_IdChanging(long value);
    partial void OnRoom_IdChanged();
    partial void OnHotel_IdChanging(long value);
    partial void OnHotel_IdChanged();
    partial void OnRoomTypeChanging(string value);
    partial void OnRoomTypeChanged();
    partial void OnRatesChanging(long value);
    partial void OnRatesChanged();
    partial void OnAvailableRoomsChanging(long value);
    partial void OnAvailableRoomsChanged();
    partial void OnTotalRoomsChanging(long value);
    partial void OnTotalRoomsChanged();
    #endregion
		
		public HotelRoom()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Room_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Room_Id
		{
			get
			{
				return this._Room_Id;
			}
			set
			{
				if ((this._Room_Id != value))
				{
					this.OnRoom_IdChanging(value);
					this.SendPropertyChanging();
					this._Room_Id = value;
					this.SendPropertyChanged("Room_Id");
					this.OnRoom_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotel_Id", DbType="BigInt NOT NULL")]
		public long Hotel_Id
		{
			get
			{
				return this._Hotel_Id;
			}
			set
			{
				if ((this._Hotel_Id != value))
				{
					this.OnHotel_IdChanging(value);
					this.SendPropertyChanging();
					this._Hotel_Id = value;
					this.SendPropertyChanged("Hotel_Id");
					this.OnHotel_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string RoomType
		{
			get
			{
				return this._RoomType;
			}
			set
			{
				if ((this._RoomType != value))
				{
					this.OnRoomTypeChanging(value);
					this.SendPropertyChanging();
					this._RoomType = value;
					this.SendPropertyChanged("RoomType");
					this.OnRoomTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rates", DbType="BigInt NOT NULL")]
		public long Rates
		{
			get
			{
				return this._Rates;
			}
			set
			{
				if ((this._Rates != value))
				{
					this.OnRatesChanging(value);
					this.SendPropertyChanging();
					this._Rates = value;
					this.SendPropertyChanged("Rates");
					this.OnRatesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AvailableRooms", DbType="BigInt NOT NULL")]
		public long AvailableRooms
		{
			get
			{
				return this._AvailableRooms;
			}
			set
			{
				if ((this._AvailableRooms != value))
				{
					this.OnAvailableRoomsChanging(value);
					this.SendPropertyChanging();
					this._AvailableRooms = value;
					this.SendPropertyChanged("AvailableRooms");
					this.OnAvailableRoomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalRooms", DbType="BigInt NOT NULL")]
		public long TotalRooms
		{
			get
			{
				return this._TotalRooms;
			}
			set
			{
				if ((this._TotalRooms != value))
				{
					this.OnTotalRoomsChanging(value);
					this.SendPropertyChanging();
					this._TotalRooms = value;
					this.SendPropertyChanged("TotalRooms");
					this.OnTotalRoomsChanged();
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
