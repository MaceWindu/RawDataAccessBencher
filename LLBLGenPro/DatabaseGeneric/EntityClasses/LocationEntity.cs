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
	/// <summary>Entity class which represents the entity 'Location'.<br/><br/></summary>
	[Serializable]
	public partial class LocationEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProductInventoryEntity> _productInventories;
		private EntityCollection<WorkOrderRoutingEntity> _workOrderRoutings;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static LocationEntityStaticMetaData _staticMetaData = new LocationEntityStaticMetaData();
		private static LocationRelations _relationsFactory = new LocationRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductInventories</summary>
			public static readonly string ProductInventories = "ProductInventories";
			/// <summary>Member name WorkOrderRoutings</summary>
			public static readonly string WorkOrderRoutings = "WorkOrderRoutings";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class LocationEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public LocationEntityStaticMetaData()
			{
				SetEntityCoreInfo("LocationEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.LocationEntity, typeof(LocationEntity), typeof(LocationEntityFactory), false);
				AddNavigatorMetaData<LocationEntity, EntityCollection<ProductInventoryEntity>>("ProductInventories", a => a._productInventories, (a, b) => a._productInventories = b, a => a.ProductInventories, () => new LocationRelations().ProductInventoryEntityUsingLocationId, typeof(ProductInventoryEntity), (int)AdventureWorks.Dal.Adapter.EntityType.ProductInventoryEntity);
				AddNavigatorMetaData<LocationEntity, EntityCollection<WorkOrderRoutingEntity>>("WorkOrderRoutings", a => a._workOrderRoutings, (a, b) => a._workOrderRoutings = b, a => a.WorkOrderRoutings, () => new LocationRelations().WorkOrderRoutingEntityUsingLocationId, typeof(WorkOrderRoutingEntity), (int)AdventureWorks.Dal.Adapter.EntityType.WorkOrderRoutingEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static LocationEntity()
		{
		}

		/// <summary> CTor</summary>
		public LocationEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public LocationEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this LocationEntity</param>
		public LocationEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="locationId">PK value for Location which data should be fetched into this Location object</param>
		public LocationEntity(System.Int16 locationId) : this(locationId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="locationId">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="validator">The custom validator object for this LocationEntity</param>
		public LocationEntity(System.Int16 locationId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.LocationId = locationId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LocationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductInventory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductInventories() { return CreateRelationInfoForNavigator("ProductInventories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'WorkOrderRouting' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderRoutings() { return CreateRelationInfoForNavigator("WorkOrderRoutings"); }
		
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
		/// <param name="validator">The validator object for this LocationEntity</param>
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
		public static LocationRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductInventory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductInventories { get { return _staticMetaData.GetPrefetchPathElement("ProductInventories", CommonEntityBase.CreateEntityCollection<ProductInventoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderRouting' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderRoutings { get { return _staticMetaData.GetPrefetchPathElement("WorkOrderRoutings", CommonEntityBase.CreateEntityCollection<WorkOrderRoutingEntity>()); } }

		/// <summary>The Availability property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."Availability".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Availability
		{
			get { return (System.Decimal)GetValue((int)LocationFieldIndex.Availability, true); }
			set	{ SetValue((int)LocationFieldIndex.Availability, value); }
		}

		/// <summary>The CostRate property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."CostRate".<br/>Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostRate
		{
			get { return (System.Decimal)GetValue((int)LocationFieldIndex.CostRate, true); }
			set	{ SetValue((int)LocationFieldIndex.CostRate, value); }
		}

		/// <summary>The LocationId property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."LocationID".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 LocationId
		{
			get { return (System.Int16)GetValue((int)LocationFieldIndex.LocationId, true); }
			set { SetValue((int)LocationFieldIndex.LocationId, value); }		}

		/// <summary>The ModifiedDate property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)LocationFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)LocationFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)LocationFieldIndex.Name, true); }
			set	{ SetValue((int)LocationFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductInventoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductInventoryEntity))]
		public virtual EntityCollection<ProductInventoryEntity> ProductInventories { get { return GetOrCreateEntityCollection<ProductInventoryEntity, ProductInventoryEntityFactory>("Location", true, false, ref _productInventories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'WorkOrderRoutingEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(WorkOrderRoutingEntity))]
		public virtual EntityCollection<WorkOrderRoutingEntity> WorkOrderRoutings { get { return GetOrCreateEntityCollection<WorkOrderRoutingEntity, WorkOrderRoutingEntityFactory>("Location", true, false, ref _workOrderRoutings); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum LocationFieldIndex
	{
		///<summary>Availability. </summary>
		Availability,
		///<summary>CostRate. </summary>
		CostRate,
		///<summary>LocationId. </summary>
		LocationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Location. </summary>
	public partial class LocationRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between LocationEntity and ProductInventoryEntity over the 1:n relation they have, using the relation between the fields: Location.LocationId - ProductInventory.LocationId</summary>
		public virtual IEntityRelation ProductInventoryEntityUsingLocationId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductInventories", true, new[] { LocationFields.LocationId, ProductInventoryFields.LocationId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between LocationEntity and WorkOrderRoutingEntity over the 1:n relation they have, using the relation between the fields: Location.LocationId - WorkOrderRouting.LocationId</summary>
		public virtual IEntityRelation WorkOrderRoutingEntityUsingLocationId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "WorkOrderRoutings", true, new[] { LocationFields.LocationId, WorkOrderRoutingFields.LocationId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticLocationRelations
	{
		internal static readonly IEntityRelation ProductInventoryEntityUsingLocationIdStatic = new LocationRelations().ProductInventoryEntityUsingLocationId;
		internal static readonly IEntityRelation WorkOrderRoutingEntityUsingLocationIdStatic = new LocationRelations().WorkOrderRoutingEntityUsingLocationId;

		/// <summary>CTor</summary>
		static StaticLocationRelations() { }
	}
}
