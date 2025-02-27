﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Password'.<br/><br/></summary>
	[Serializable]
	public partial class PasswordEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private PersonEntity _person;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static PasswordEntityStaticMetaData _staticMetaData = new PasswordEntityStaticMetaData();
		private static PasswordRelations _relationsFactory = new PasswordRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PasswordEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PasswordEntityStaticMetaData()
			{
				SetEntityCoreInfo("PasswordEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.PasswordEntity, typeof(PasswordEntity), typeof(PasswordEntityFactory), false);
				AddNavigatorMetaData<PasswordEntity, PersonEntity>("Person", "Password", (a, b) => a._person = b, a => a._person, (a, b) => a.Person = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticPasswordRelations.PersonEntityUsingBusinessEntityIdStatic, ()=>new PasswordRelations().PersonEntityUsingBusinessEntityId, null, new int[] { (int)PasswordFieldIndex.BusinessEntityId }, null, false, (int)AdventureWorks.Dal.Adapter.EntityType.PersonEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PasswordEntity()
		{
		}

		/// <summary> CTor</summary>
		public PasswordEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PasswordEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PasswordEntity</param>
		public PasswordEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for Password which data should be fetched into this Password object</param>
		public PasswordEntity(System.Int32 businessEntityId) : this(businessEntityId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for Password which data should be fetched into this Password object</param>
		/// <param name="validator">The custom validator object for this PasswordEntity</param>
		public PasswordEntity(System.Int32 businessEntityId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PasswordEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson() { return CreateRelationInfoForNavigator("Person"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PasswordEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static PasswordRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson { get { return _staticMetaData.GetPrefetchPathElement("Person", CommonEntityBase.CreateEntityCollection<PersonEntity>()); } }

		/// <summary>The BusinessEntityId property of the Entity Password<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Password"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)PasswordFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)PasswordFieldIndex.BusinessEntityId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Password<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Password"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PasswordFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PasswordFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The PasswordHash property of the Entity Password<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Password"."PasswordHash".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 128.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordHash
		{
			get { return (System.String)GetValue((int)PasswordFieldIndex.PasswordHash, true); }
			set	{ SetValue((int)PasswordFieldIndex.PasswordHash, value); }
		}

		/// <summary>The PasswordSalt property of the Entity Password<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Password"."PasswordSalt".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordSalt
		{
			get { return (System.String)GetValue((int)PasswordFieldIndex.PasswordSalt, true); }
			set	{ SetValue((int)PasswordFieldIndex.PasswordSalt, value); }
		}

		/// <summary>The Rowguid property of the Entity Password<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Password"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)PasswordFieldIndex.Rowguid, true); }
			set	{ SetValue((int)PasswordFieldIndex.Rowguid, value); }
		}

		/// <summary>Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set { SetSingleRelatedEntityNavigator(value, "Person"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum PasswordFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PasswordHash. </summary>
		PasswordHash,
		///<summary>PasswordSalt. </summary>
		PasswordSalt,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Password. </summary>
	public partial class PasswordRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between PasswordEntity and PersonEntity over the 1:1 relation they have, using the relation between the fields: Password.BusinessEntityId - Person.BusinessEntityId</summary>
		public virtual IEntityRelation PersonEntityUsingBusinessEntityId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "Person", false, new[] { PersonFields.BusinessEntityId, PasswordFields.BusinessEntityId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPasswordRelations
	{
		internal static readonly IEntityRelation PersonEntityUsingBusinessEntityIdStatic = new PasswordRelations().PersonEntityUsingBusinessEntityId;

		/// <summary>CTor</summary>
		static StaticPasswordRelations() { }
	}
}
