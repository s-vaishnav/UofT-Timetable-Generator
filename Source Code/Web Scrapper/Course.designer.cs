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

namespace Web_Scrapper
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UoftDatabase")]
	public partial class CourseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertActivity(Activity instance);
    partial void UpdateActivity(Activity instance);
    partial void DeleteActivity(Activity instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertInstructor(Instructor instance);
    partial void UpdateInstructor(Instructor instance);
    partial void DeleteInstructor(Instructor instance);
    partial void InsertInstructorToActivity(InstructorToActivity instance);
    partial void UpdateInstructorToActivity(InstructorToActivity instance);
    partial void DeleteInstructorToActivity(InstructorToActivity instance);
    partial void InsertSession(Session instance);
    partial void UpdateSession(Session instance);
    partial void DeleteSession(Session instance);
    #endregion
		
		public CourseDataContext() : 
				base(global::Web_Scrapper.Properties.Settings.Default.UoftDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CourseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CourseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CourseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CourseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Activity> Activities
		{
			get
			{
				return this.GetTable<Activity>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Instructor> Instructors
		{
			get
			{
				return this.GetTable<Instructor>();
			}
		}
		
		public System.Data.Linq.Table<InstructorToActivity> InstructorToActivities
		{
			get
			{
				return this.GetTable<InstructorToActivity>();
			}
		}
		
		public System.Data.Linq.Table<Session> Sessions
		{
			get
			{
				return this.GetTable<Session>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Activity")]
	public partial class Activity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _CourseID;
		
		private string _ActivityCode;
		
		private System.Nullable<char> _ActivityType;
		
		private EntitySet<InstructorToActivity> _InstructorToActivities;
		
		private EntitySet<Session> _Sessions;
		
		private EntityRef<Course> _Course;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCourseIDChanging(int value);
    partial void OnCourseIDChanged();
    partial void OnActivityCodeChanging(string value);
    partial void OnActivityCodeChanged();
    partial void OnActivityTypeChanging(System.Nullable<char> value);
    partial void OnActivityTypeChanged();
    #endregion
		
		public Activity()
		{
			this._InstructorToActivities = new EntitySet<InstructorToActivity>(new Action<InstructorToActivity>(this.attach_InstructorToActivities), new Action<InstructorToActivity>(this.detach_InstructorToActivities));
			this._Sessions = new EntitySet<Session>(new Action<Session>(this.attach_Sessions), new Action<Session>(this.detach_Sessions));
			this._Course = default(EntityRef<Course>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseID", DbType="Int NOT NULL")]
		public int CourseID
		{
			get
			{
				return this._CourseID;
			}
			set
			{
				if ((this._CourseID != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIDChanging(value);
					this.SendPropertyChanging();
					this._CourseID = value;
					this.SendPropertyChanged("CourseID");
					this.OnCourseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityCode", DbType="NVarChar(MAX)")]
		public string ActivityCode
		{
			get
			{
				return this._ActivityCode;
			}
			set
			{
				if ((this._ActivityCode != value))
				{
					this.OnActivityCodeChanging(value);
					this.SendPropertyChanging();
					this._ActivityCode = value;
					this.SendPropertyChanged("ActivityCode");
					this.OnActivityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityType", DbType="Char(1)")]
		public System.Nullable<char> ActivityType
		{
			get
			{
				return this._ActivityType;
			}
			set
			{
				if ((this._ActivityType != value))
				{
					this.OnActivityTypeChanging(value);
					this.SendPropertyChanging();
					this._ActivityType = value;
					this.SendPropertyChanged("ActivityType");
					this.OnActivityTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activity_InstructorToActivity", Storage="_InstructorToActivities", ThisKey="Id", OtherKey="ActivityID")]
		public EntitySet<InstructorToActivity> InstructorToActivities
		{
			get
			{
				return this._InstructorToActivities;
			}
			set
			{
				this._InstructorToActivities.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activity_Session", Storage="_Sessions", ThisKey="Id", OtherKey="ActivityID")]
		public EntitySet<Session> Sessions
		{
			get
			{
				return this._Sessions;
			}
			set
			{
				this._Sessions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Activity", Storage="_Course", ThisKey="CourseID", OtherKey="Id", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Activities.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Activities.Add(this);
						this._CourseID = value.Id;
					}
					else
					{
						this._CourseID = default(int);
					}
					this.SendPropertyChanged("Course");
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
		
		private void attach_InstructorToActivities(InstructorToActivity entity)
		{
			this.SendPropertyChanging();
			entity.Activity = this;
		}
		
		private void detach_InstructorToActivities(InstructorToActivity entity)
		{
			this.SendPropertyChanging();
			entity.Activity = null;
		}
		
		private void attach_Sessions(Session entity)
		{
			this.SendPropertyChanging();
			entity.Activity = this;
		}
		
		private void detach_Sessions(Session entity)
		{
			this.SendPropertyChanging();
			entity.Activity = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Course")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Code;
		
		private string _Title;
		
		private System.Nullable<char> _Term;
		
		private EntitySet<Activity> _Activities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTermChanging(System.Nullable<char> value);
    partial void OnTermChanged();
    #endregion
		
		public Course()
		{
			this._Activities = new EntitySet<Activity>(new Action<Activity>(this.attach_Activities), new Action<Activity>(this.detach_Activities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="NVarChar(10)")]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Term", DbType="Char(1)")]
		public System.Nullable<char> Term
		{
			get
			{
				return this._Term;
			}
			set
			{
				if ((this._Term != value))
				{
					this.OnTermChanging(value);
					this.SendPropertyChanging();
					this._Term = value;
					this.SendPropertyChanged("Term");
					this.OnTermChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Activity", Storage="_Activities", ThisKey="Id", OtherKey="CourseID")]
		public EntitySet<Activity> Activities
		{
			get
			{
				return this._Activities;
			}
			set
			{
				this._Activities.Assign(value);
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
		
		private void attach_Activities(Activity entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Activities(Activity entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Instructor")]
	public partial class Instructor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<double> _Rating;
		
		private EntitySet<InstructorToActivity> _InstructorToActivities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnRatingChanging(System.Nullable<double> value);
    partial void OnRatingChanged();
    #endregion
		
		public Instructor()
		{
			this._InstructorToActivities = new EntitySet<InstructorToActivity>(new Action<InstructorToActivity>(this.attach_InstructorToActivities), new Action<InstructorToActivity>(this.detach_InstructorToActivities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Float")]
		public System.Nullable<double> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Instructor_InstructorToActivity", Storage="_InstructorToActivities", ThisKey="Id", OtherKey="InstructorID")]
		public EntitySet<InstructorToActivity> InstructorToActivities
		{
			get
			{
				return this._InstructorToActivities;
			}
			set
			{
				this._InstructorToActivities.Assign(value);
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
		
		private void attach_InstructorToActivities(InstructorToActivity entity)
		{
			this.SendPropertyChanging();
			entity.Instructor = this;
		}
		
		private void detach_InstructorToActivities(InstructorToActivity entity)
		{
			this.SendPropertyChanging();
			entity.Instructor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InstructorToActivity")]
	public partial class InstructorToActivity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _InstructorID;
		
		private int _ActivityID;
		
		private EntityRef<Activity> _Activity;
		
		private EntityRef<Instructor> _Instructor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnInstructorIDChanging(int value);
    partial void OnInstructorIDChanged();
    partial void OnActivityIDChanging(int value);
    partial void OnActivityIDChanged();
    #endregion
		
		public InstructorToActivity()
		{
			this._Activity = default(EntityRef<Activity>);
			this._Instructor = default(EntityRef<Instructor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorID", DbType="Int NOT NULL")]
		public int InstructorID
		{
			get
			{
				return this._InstructorID;
			}
			set
			{
				if ((this._InstructorID != value))
				{
					if (this._Instructor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnInstructorIDChanging(value);
					this.SendPropertyChanging();
					this._InstructorID = value;
					this.SendPropertyChanged("InstructorID");
					this.OnInstructorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityID", DbType="Int NOT NULL")]
		public int ActivityID
		{
			get
			{
				return this._ActivityID;
			}
			set
			{
				if ((this._ActivityID != value))
				{
					if (this._Activity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActivityIDChanging(value);
					this.SendPropertyChanging();
					this._ActivityID = value;
					this.SendPropertyChanged("ActivityID");
					this.OnActivityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activity_InstructorToActivity", Storage="_Activity", ThisKey="ActivityID", OtherKey="Id", IsForeignKey=true)]
		public Activity Activity
		{
			get
			{
				return this._Activity.Entity;
			}
			set
			{
				Activity previousValue = this._Activity.Entity;
				if (((previousValue != value) 
							|| (this._Activity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Activity.Entity = null;
						previousValue.InstructorToActivities.Remove(this);
					}
					this._Activity.Entity = value;
					if ((value != null))
					{
						value.InstructorToActivities.Add(this);
						this._ActivityID = value.Id;
					}
					else
					{
						this._ActivityID = default(int);
					}
					this.SendPropertyChanged("Activity");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Instructor_InstructorToActivity", Storage="_Instructor", ThisKey="InstructorID", OtherKey="Id", IsForeignKey=true)]
		public Instructor Instructor
		{
			get
			{
				return this._Instructor.Entity;
			}
			set
			{
				Instructor previousValue = this._Instructor.Entity;
				if (((previousValue != value) 
							|| (this._Instructor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Instructor.Entity = null;
						previousValue.InstructorToActivities.Remove(this);
					}
					this._Instructor.Entity = value;
					if ((value != null))
					{
						value.InstructorToActivities.Add(this);
						this._InstructorID = value.Id;
					}
					else
					{
						this._InstructorID = default(int);
					}
					this.SendPropertyChanged("Instructor");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Session")]
	public partial class Session : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ActivityID;
		
		private System.Nullable<int> _Fall_BuildingID;
		
		private string _Fall_RoomNumber;
		
		private System.Nullable<int> _Winter_BuildingID;
		
		private string _Winter_RoomNumber;
		
		private System.Nullable<double> _StartTime;
		
		private System.Nullable<double> _EndTime;
		
		private EntityRef<Activity> _Activity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnActivityIDChanging(int value);
    partial void OnActivityIDChanged();
    partial void OnFall_BuildingIDChanging(System.Nullable<int> value);
    partial void OnFall_BuildingIDChanged();
    partial void OnFall_RoomNumberChanging(string value);
    partial void OnFall_RoomNumberChanged();
    partial void OnWinter_BuildingIDChanging(System.Nullable<int> value);
    partial void OnWinter_BuildingIDChanged();
    partial void OnWinter_RoomNumberChanging(string value);
    partial void OnWinter_RoomNumberChanged();
    partial void OnStartTimeChanging(System.Nullable<double> value);
    partial void OnStartTimeChanged();
    partial void OnEndTimeChanging(System.Nullable<double> value);
    partial void OnEndTimeChanged();
    #endregion
		
		public Session()
		{
			this._Activity = default(EntityRef<Activity>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityID", DbType="Int NOT NULL")]
		public int ActivityID
		{
			get
			{
				return this._ActivityID;
			}
			set
			{
				if ((this._ActivityID != value))
				{
					if (this._Activity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActivityIDChanging(value);
					this.SendPropertyChanging();
					this._ActivityID = value;
					this.SendPropertyChanged("ActivityID");
					this.OnActivityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fall_BuildingID", DbType="Int")]
		public System.Nullable<int> Fall_BuildingID
		{
			get
			{
				return this._Fall_BuildingID;
			}
			set
			{
				if ((this._Fall_BuildingID != value))
				{
					this.OnFall_BuildingIDChanging(value);
					this.SendPropertyChanging();
					this._Fall_BuildingID = value;
					this.SendPropertyChanged("Fall_BuildingID");
					this.OnFall_BuildingIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fall_RoomNumber", DbType="NVarChar(MAX)")]
		public string Fall_RoomNumber
		{
			get
			{
				return this._Fall_RoomNumber;
			}
			set
			{
				if ((this._Fall_RoomNumber != value))
				{
					this.OnFall_RoomNumberChanging(value);
					this.SendPropertyChanging();
					this._Fall_RoomNumber = value;
					this.SendPropertyChanged("Fall_RoomNumber");
					this.OnFall_RoomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Winter_BuildingID", DbType="Int")]
		public System.Nullable<int> Winter_BuildingID
		{
			get
			{
				return this._Winter_BuildingID;
			}
			set
			{
				if ((this._Winter_BuildingID != value))
				{
					this.OnWinter_BuildingIDChanging(value);
					this.SendPropertyChanging();
					this._Winter_BuildingID = value;
					this.SendPropertyChanged("Winter_BuildingID");
					this.OnWinter_BuildingIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Winter_RoomNumber", DbType="NVarChar(MAX)")]
		public string Winter_RoomNumber
		{
			get
			{
				return this._Winter_RoomNumber;
			}
			set
			{
				if ((this._Winter_RoomNumber != value))
				{
					this.OnWinter_RoomNumberChanging(value);
					this.SendPropertyChanging();
					this._Winter_RoomNumber = value;
					this.SendPropertyChanged("Winter_RoomNumber");
					this.OnWinter_RoomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="Float")]
		public System.Nullable<double> StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="Float")]
		public System.Nullable<double> EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activity_Session", Storage="_Activity", ThisKey="ActivityID", OtherKey="Id", IsForeignKey=true)]
		public Activity Activity
		{
			get
			{
				return this._Activity.Entity;
			}
			set
			{
				Activity previousValue = this._Activity.Entity;
				if (((previousValue != value) 
							|| (this._Activity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Activity.Entity = null;
						previousValue.Sessions.Remove(this);
					}
					this._Activity.Entity = value;
					if ((value != null))
					{
						value.Sessions.Add(this);
						this._ActivityID = value.Id;
					}
					else
					{
						this._ActivityID = default(int);
					}
					this.SendPropertyChanged("Activity");
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