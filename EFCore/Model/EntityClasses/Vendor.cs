﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Vendor'.</summary>
	public partial class Vendor : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="Vendor"/> class.</summary>
		public Vendor() : base()
		{
			this.ProductVendors = new List<ProductVendor>();
			this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
			OnCreated();
		}

		/// <summary>Gets or sets the AccountNumber field. </summary>
		public System.String AccountNumber { get; set;}
		/// <summary>Gets or sets the ActiveFlag field. </summary>
		public System.Boolean ActiveFlag { get; set;}
		/// <summary>Gets or sets the CreditRating field. </summary>
		public System.Byte CreditRating { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the PreferredVendorStatus field. </summary>
		public System.Boolean PreferredVendorStatus { get; set;}
		/// <summary>Gets or sets the PurchasingWebServiceUrl field. </summary>
		public System.String PurchasingWebServiceUrl { get; set;}
		/// <summary>Gets or sets the VendorId field. </summary>
		public System.Int32 VendorId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Vendor.BusinessEntity - Person.BusinessEntity.Vendor (1:1)'</summary>
		public virtual BusinessEntity BusinessEntity { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.Vendor - Vendor.ProductVendors (m:1)'</summary>
		public virtual List<ProductVendor> ProductVendors { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Vendor - Vendor.PurchaseOrderHeaders (m:1)'</summary>
		public virtual List<PurchaseOrderHeader> PurchaseOrderHeaders { get; set;}
	}
}