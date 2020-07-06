// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Permission Set Assignment
	///<para>SObject Name: PermissionSetAssignment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPermissionSetAssignment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PermissionSetAssignment"; }
		}

		///<summary>
		/// PermissionSetAssignment ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// PermissionSet ID
		/// <para>Name: PermissionSetId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSetId")]
		[Updateable(false), Createable(true)]
		public string PermissionSetId { get; set; }

		///<summary>
		/// ReferenceTo: PermissionSet
		/// <para>RelationshipName: PermissionSet</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSet")]
		[Updateable(false), Createable(false)]
		public SfPermissionSet PermissionSet { get; set; }

		///<summary>
		/// Assignee ID
		/// <para>Name: AssigneeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "assigneeId")]
		[Updateable(false), Createable(true)]
		public string AssigneeId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Assignee</para>
		///</summary>
		[JsonProperty(PropertyName = "assignee")]
		[Updateable(false), Createable(false)]
		public SfUser Assignee { get; set; }

		///<summary>
		/// Date Assigned
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
