﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5472
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class SupplierInvoiceFileConnection
	{

		private string fileIdField;

		private string nameField;

		private string supplierInvoiceNumberField;

		private string supplierNameField;

		private string urlField;

		/// <remarks/>
		public string FileId
		{
			get
			{
				return this.fileIdField;
			}
			set
			{
				this.fileIdField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public string SupplierInvoiceNumber
		{
			get
			{
				return this.supplierInvoiceNumberField;
			}
			set
			{
				this.supplierInvoiceNumberField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string SupplierName
		{
			get
			{
				return this.supplierNameField;
			}
			set
			{
				this.supplierNameField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.ReadOnly(true)]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}
}