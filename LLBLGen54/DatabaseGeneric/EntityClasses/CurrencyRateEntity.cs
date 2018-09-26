﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
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
using AdventureWorks.Dal.Adapter.v54.HelperClasses;
using AdventureWorks.Dal.Adapter.v54.FactoryClasses;
using AdventureWorks.Dal.Adapter.v54.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v54.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'CurrencyRate'.<br/><br/></summary>
	[Serializable]
	public partial class CurrencyRateEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private CurrencyEntity _currency;
		private CurrencyEntity _currency_;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static CurrencyRateEntityStaticMetaData _staticMetaData = new CurrencyRateEntityStaticMetaData();
		private static CurrencyRateRelations _relationsFactory = new CurrencyRateRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Currency</summary>
			public static readonly string Currency = "Currency";
			/// <summary>Member name Currency_</summary>
			public static readonly string Currency_ = "Currency_";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class CurrencyRateEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public CurrencyRateEntityStaticMetaData()
			{
				SetEntityCoreInfo("CurrencyRateEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CurrencyRateEntity, typeof(CurrencyRateEntity), typeof(CurrencyRateEntityFactory), false);
				AddNavigatorMetaData<CurrencyRateEntity, EntityCollection<SalesOrderHeaderEntity>>("SalesOrderHeaders", a => a._salesOrderHeaders, (a, b) => a._salesOrderHeaders = b, a => a.SalesOrderHeaders, () => new CurrencyRateRelations().SalesOrderHeaderEntityUsingCurrencyRateId, typeof(SalesOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesOrderHeaderEntity);
				AddNavigatorMetaData<CurrencyRateEntity, CurrencyEntity>("Currency", "CurrencyRates", (a, b) => a._currency = b, a => a._currency, (a, b) => a.Currency = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingFromCurrencyCodeStatic, ()=>new CurrencyRateRelations().CurrencyEntityUsingFromCurrencyCode, null, new int[] { (int)CurrencyRateFieldIndex.FromCurrencyCode }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CurrencyEntity);
				AddNavigatorMetaData<CurrencyRateEntity, CurrencyEntity>("Currency_", "CurrencyRates_", (a, b) => a._currency_ = b, a => a._currency_, (a, b) => a.Currency_ = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingToCurrencyCodeStatic, ()=>new CurrencyRateRelations().CurrencyEntityUsingToCurrencyCode, null, new int[] { (int)CurrencyRateFieldIndex.ToCurrencyCode }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CurrencyEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static CurrencyRateEntity()
		{
		}

		/// <summary> CTor</summary>
		public CurrencyRateEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CurrencyRateEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CurrencyRateEntity</param>
		public CurrencyRateEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="currencyRateId">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		public CurrencyRateEntity(System.Int32 currencyRateId) : this(currencyRateId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="currencyRateId">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="validator">The custom validator object for this CurrencyRateEntity</param>
		public CurrencyRateEntity(System.Int32 currencyRateId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.CurrencyRateId = currencyRateId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CurrencyRateEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders() { return CreateRelationInfoForNavigator("SalesOrderHeaders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrency() { return CreateRelationInfoForNavigator("Currency"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrency_() { return CreateRelationInfoForNavigator("Currency_"); }
		
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
		/// <param name="validator">The validator object for this CurrencyRateEntity</param>
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
		public static CurrencyRateRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeaders", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrency { get { return _staticMetaData.GetPrefetchPathElement("Currency", CommonEntityBase.CreateEntityCollection<CurrencyEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrency_ { get { return _staticMetaData.GetPrefetchPathElement("Currency_", CommonEntityBase.CreateEntityCollection<CurrencyEntity>()); } }

		/// <summary>The AverageRate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."AverageRate".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal AverageRate
		{
			get { return (System.Decimal)GetValue((int)CurrencyRateFieldIndex.AverageRate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.AverageRate, value); }
		}

		/// <summary>The CurrencyRateDate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."CurrencyRateDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CurrencyRateDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyRateFieldIndex.CurrencyRateDate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.CurrencyRateDate, value); }
		}

		/// <summary>The CurrencyRateId property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."CurrencyRateID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CurrencyRateId
		{
			get { return (System.Int32)GetValue((int)CurrencyRateFieldIndex.CurrencyRateId, true); }
			set { SetValue((int)CurrencyRateFieldIndex.CurrencyRateId, value); }		}

		/// <summary>The EndOfDayRate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."EndOfDayRate".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal EndOfDayRate
		{
			get { return (System.Decimal)GetValue((int)CurrencyRateFieldIndex.EndOfDayRate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.EndOfDayRate, value); }
		}

		/// <summary>The FromCurrencyCode property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."FromCurrencyCode".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FromCurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyRateFieldIndex.FromCurrencyCode, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.FromCurrencyCode, value); }
		}

		/// <summary>The ModifiedDate property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyRateFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ToCurrencyCode property of the Entity CurrencyRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."ToCurrencyCode".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ToCurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyRateFieldIndex.ToCurrencyCode, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.ToCurrencyCode, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders { get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("CurrencyRate", true, false, ref _salesOrderHeaders); } }

		/// <summary>Gets / sets related entity of type 'CurrencyEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CurrencyEntity Currency
		{
			get { return _currency; }
			set { SetSingleRelatedEntityNavigator(value, "Currency"); }
		}

		/// <summary>Gets / sets related entity of type 'CurrencyEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CurrencyEntity Currency_
		{
			get { return _currency_; }
			set { SetSingleRelatedEntityNavigator(value, "Currency_"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum CurrencyRateFieldIndex
	{
		///<summary>AverageRate. </summary>
		AverageRate,
		///<summary>CurrencyRateDate. </summary>
		CurrencyRateDate,
		///<summary>CurrencyRateId. </summary>
		CurrencyRateId,
		///<summary>EndOfDayRate. </summary>
		EndOfDayRate,
		///<summary>FromCurrencyCode. </summary>
		FromCurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ToCurrencyCode. </summary>
		ToCurrencyCode,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: CurrencyRate. </summary>
	public partial class CurrencyRateRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: CurrencyRate.CurrencyRateId - SalesOrderHeader.CurrencyRateId</summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingCurrencyRateId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderHeaders", true, new[] { CurrencyRateFields.CurrencyRateId, SalesOrderHeaderFields.CurrencyRateId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields: CurrencyRate.FromCurrencyCode - Currency.CurrencyCode</summary>
		public virtual IEntityRelation CurrencyEntityUsingFromCurrencyCode
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Currency", false, new[] { CurrencyFields.CurrencyCode, CurrencyRateFields.FromCurrencyCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields: CurrencyRate.ToCurrencyCode - Currency.CurrencyCode</summary>
		public virtual IEntityRelation CurrencyEntityUsingToCurrencyCode
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Currency_", false, new[] { CurrencyFields.CurrencyCode, CurrencyRateFields.ToCurrencyCode }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCurrencyRateRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingCurrencyRateIdStatic = new CurrencyRateRelations().SalesOrderHeaderEntityUsingCurrencyRateId;
		internal static readonly IEntityRelation CurrencyEntityUsingFromCurrencyCodeStatic = new CurrencyRateRelations().CurrencyEntityUsingFromCurrencyCode;
		internal static readonly IEntityRelation CurrencyEntityUsingToCurrencyCodeStatic = new CurrencyRateRelations().CurrencyEntityUsingToCurrencyCode;

		/// <summary>CTor</summary>
		static StaticCurrencyRateRelations() { }
	}
}