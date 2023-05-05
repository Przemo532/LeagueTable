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

namespace LeagueTable
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DatabaseSport")]
	public partial class DataClassesSportDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMatch(Match instance);
    partial void UpdateMatch(Match instance);
    partial void DeleteMatch(Match instance);
    partial void InsertTeam(Team instance);
    partial void UpdateTeam(Team instance);
    partial void DeleteTeam(Team instance);
    #endregion
		
		public DataClassesSportDataContext() : 
				base(global::LeagueTable.Properties.Settings.Default.DatabaseSportConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSportDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSportDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSportDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSportDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Match> Matches
		{
			get
			{
				return this.GetTable<Match>();
			}
		}
		
		public System.Data.Linq.Table<Team> Teams
		{
			get
			{
				return this.GetTable<Team>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Match")]
	public partial class Match : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _TeamHostId;
		
		private int _TeamGuestId;
		
		private int _GoalHost;
		
		private int _GoalGuest;
		
		private EntityRef<Team> _Team;
		
		private EntityRef<Team> _Team1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTeamHostIdChanging(int value);
    partial void OnTeamHostIdChanged();
    partial void OnTeamGuestIdChanging(int value);
    partial void OnTeamGuestIdChanged();
    partial void OnGoalHostChanging(int value);
    partial void OnGoalHostChanged();
    partial void OnGoalGuestChanging(int value);
    partial void OnGoalGuestChanged();
    #endregion
		
		public Match()
		{
			this._Team = default(EntityRef<Team>);
			this._Team1 = default(EntityRef<Team>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamHostId", DbType="Int NOT NULL")]
		public int TeamHostId
		{
			get
			{
				return this._TeamHostId;
			}
			set
			{
				if ((this._TeamHostId != value))
				{
					if (this._Team1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeamHostIdChanging(value);
					this.SendPropertyChanging();
					this._TeamHostId = value;
					this.SendPropertyChanged("TeamHostId");
					this.OnTeamHostIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamGuestId", DbType="Int NOT NULL")]
		public int TeamGuestId
		{
			get
			{
				return this._TeamGuestId;
			}
			set
			{
				if ((this._TeamGuestId != value))
				{
					if (this._Team.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeamGuestIdChanging(value);
					this.SendPropertyChanging();
					this._TeamGuestId = value;
					this.SendPropertyChanged("TeamGuestId");
					this.OnTeamGuestIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GoalHost", DbType="Int NOT NULL")]
		public int GoalHost
		{
			get
			{
				return this._GoalHost;
			}
			set
			{
				if ((this._GoalHost != value))
				{
					this.OnGoalHostChanging(value);
					this.SendPropertyChanging();
					this._GoalHost = value;
					this.SendPropertyChanged("GoalHost");
					this.OnGoalHostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GoalGuest", DbType="Int NOT NULL")]
		public int GoalGuest
		{
			get
			{
				return this._GoalGuest;
			}
			set
			{
				if ((this._GoalGuest != value))
				{
					this.OnGoalGuestChanging(value);
					this.SendPropertyChanging();
					this._GoalGuest = value;
					this.SendPropertyChanged("GoalGuest");
					this.OnGoalGuestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Team_Match", Storage="_Team", ThisKey="TeamGuestId", OtherKey="Id", IsForeignKey=true)]
		public Team Team
		{
			get
			{
				return this._Team.Entity;
			}
			set
			{
				Team previousValue = this._Team.Entity;
				if (((previousValue != value) 
							|| (this._Team.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Team.Entity = null;
						previousValue.Matches.Remove(this);
					}
					this._Team.Entity = value;
					if ((value != null))
					{
						value.Matches.Add(this);
						this._TeamGuestId = value.Id;
					}
					else
					{
						this._TeamGuestId = default(int);
					}
					this.SendPropertyChanged("Team");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Team_Match1", Storage="_Team1", ThisKey="TeamHostId", OtherKey="Id", IsForeignKey=true)]
		public Team Team1
		{
			get
			{
				return this._Team1.Entity;
			}
			set
			{
				Team previousValue = this._Team1.Entity;
				if (((previousValue != value) 
							|| (this._Team1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Team1.Entity = null;
						previousValue.Matches1.Remove(this);
					}
					this._Team1.Entity = value;
					if ((value != null))
					{
						value.Matches1.Add(this);
						this._TeamHostId = value.Id;
					}
					else
					{
						this._TeamHostId = default(int);
					}
					this.SendPropertyChanged("Team1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Team")]
	public partial class Team : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _name;
		
		private EntitySet<Match> _Matches;
		
		private EntitySet<Match> _Matches1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Team()
		{
			this._Matches = new EntitySet<Match>(new Action<Match>(this.attach_Matches), new Action<Match>(this.detach_Matches));
			this._Matches1 = new EntitySet<Match>(new Action<Match>(this.attach_Matches1), new Action<Match>(this.detach_Matches1));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Team_Match", Storage="_Matches", ThisKey="Id", OtherKey="TeamGuestId")]
		public EntitySet<Match> Matches
		{
			get
			{
				return this._Matches;
			}
			set
			{
				this._Matches.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Team_Match1", Storage="_Matches1", ThisKey="Id", OtherKey="TeamHostId")]
		public EntitySet<Match> Matches1
		{
			get
			{
				return this._Matches1;
			}
			set
			{
				this._Matches1.Assign(value);
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
		
		private void attach_Matches(Match entity)
		{
			this.SendPropertyChanging();
			entity.Team = this;
		}
		
		private void detach_Matches(Match entity)
		{
			this.SendPropertyChanging();
			entity.Team = null;
		}
		
		private void attach_Matches1(Match entity)
		{
			this.SendPropertyChanging();
			entity.Team1 = this;
		}
		
		private void detach_Matches1(Match entity)
		{
			this.SendPropertyChanging();
			entity.Team1 = null;
		}
	}
}
#pragma warning restore 1591
