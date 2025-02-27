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
	/// <summary>Entity class which represents the entity 'ShipMethod'.<br/><br/></summary>
	[Serializable]
	public partial class ShipMethodEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<PurchaseOrderHeaderEntity> _purchaseOrderHeaders;
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ShipMethodEntityStaticMetaData _staticMetaData = new ShipMethodEntityStaticMetaData();
		private static ShipMethodRelations _relationsFactory = new ShipMethodRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ShipMethodEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ShipMethodEntityStaticMetaData()
			{
				SetEntityCoreInfo("ShipMethodEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.ShipMethodEntity, typeof(ShipMethodEntity), typeof(ShipMethodEntityFactory), false);
				AddNavigatorMetaData<ShipMethodEntity, EntityCollection<PurchaseOrderHeaderEntity>>("PurchaseOrderHeaders", a => a._purchaseOrderHeaders, (a, b) => a._purchaseOrderHeaders = b, a => a.PurchaseOrderHeaders, () => new ShipMethodRelations().PurchaseOrderHeaderEntityUsingShipMethodId, typeof(PurchaseOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.EntityType.PurchaseOrderHeaderEntity);
				AddNavigatorMetaData<ShipMethodEntity, EntityCollection<SalesOrderHeaderEntity>>("SalesOrderHeaders", a => a._salesOrderHeaders, (a, b) => a._salesOrderHeaders = b, a => a.SalesOrderHeaders, () => new ShipMethodRelations().SalesOrderHeaderEntityUsingShipMethodId, typeof(SalesOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.EntityType.SalesOrderHeaderEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ShipMethodEntity()
		{
		}

		/// <summary> CTor</summary>
		public ShipMethodEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ShipMethodEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ShipMethodEntity</param>
		public ShipMethodEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		public ShipMethodEntity(System.Int32 shipMethodId) : this(shipMethodId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <param name="validator">The custom validator object for this ShipMethodEntity</param>
		public ShipMethodEntity(System.Int32 shipMethodId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ShipMethodId = shipMethodId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ShipMethodEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeaders() { return CreateRelationInfoForNavigator("PurchaseOrderHeaders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders() { return CreateRelationInfoForNavigator("SalesOrderHeaders"); }
		
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
		/// <param name="validator">The validator object for this ShipMethodEntity</param>
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
		public static ShipMethodRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeaders { get { return _staticMetaData.GetPrefetchPathElement("PurchaseOrderHeaders", CommonEntityBase.CreateEntityCollection<PurchaseOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeaders", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderEntity>()); } }

		/// <summary>The ModifiedDate property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ShipMethodFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ShipMethodFieldIndex.Name, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.Name, value); }
		}

		/// <summary>The Rowguid property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ShipMethodFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.Rowguid, value); }
		}

		/// <summary>The ShipBase property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ShipBase".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ShipBase
		{
			get { return (System.Decimal)GetValue((int)ShipMethodFieldIndex.ShipBase, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.ShipBase, value); }
		}

		/// <summary>The ShipMethodId property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ShipMethodID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ShipMethodId
		{
			get { return (System.Int32)GetValue((int)ShipMethodFieldIndex.ShipMethodId, true); }
			set { SetValue((int)ShipMethodFieldIndex.ShipMethodId, value); }		}

		/// <summary>The ShipRate property of the Entity ShipMethod<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ShipMethod"."ShipRate".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ShipRate
		{
			get { return (System.Decimal)GetValue((int)ShipMethodFieldIndex.ShipRate, true); }
			set	{ SetValue((int)ShipMethodFieldIndex.ShipRate, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'PurchaseOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderHeaderEntity))]
		public virtual EntityCollection<PurchaseOrderHeaderEntity> PurchaseOrderHeaders { get { return GetOrCreateEntityCollection<PurchaseOrderHeaderEntity, PurchaseOrderHeaderEntityFactory>("ShipMethod", true, false, ref _purchaseOrderHeaders); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders { get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("ShipMethod", true, false, ref _salesOrderHeaders); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum ShipMethodFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ShipBase. </summary>
		ShipBase,
		///<summary>ShipMethodId. </summary>
		ShipMethodId,
		///<summary>ShipRate. </summary>
		ShipRate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ShipMethod. </summary>
	public partial class ShipMethodRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ShipMethodEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: ShipMethod.ShipMethodId - PurchaseOrderHeader.ShipMethodId</summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingShipMethodId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PurchaseOrderHeaders", true, new[] { ShipMethodFields.ShipMethodId, PurchaseOrderHeaderFields.ShipMethodId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ShipMethodEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: ShipMethod.ShipMethodId - SalesOrderHeader.ShipMethodId</summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingShipMethodId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderHeaders", true, new[] { ShipMethodFields.ShipMethodId, SalesOrderHeaderFields.ShipMethodId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticShipMethodRelations
	{
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingShipMethodIdStatic = new ShipMethodRelations().PurchaseOrderHeaderEntityUsingShipMethodId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingShipMethodIdStatic = new ShipMethodRelations().SalesOrderHeaderEntityUsingShipMethodId;

		/// <summary>CTor</summary>
		static StaticShipMethodRelations() { }
	}
}
