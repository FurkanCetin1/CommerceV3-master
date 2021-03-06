﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Product
    {
		public string Id { get; set; }
		[Display(Name = "Ürün Adı")]
        [StringLength(200)]
		public string Name { get; set; }
		[Display(Name = "Bağlantı")]        
		public string Slug { get; set; }
		[Display(Name = "Açıklama")]
        [StringLength(200)]
		public string Description { get; set; }
		[Display(Name = "Eski Fiyatı")]
		public decimal OldPrice { get; set; }
		[Display(Name = "Fiyat")]
		public decimal Price { get; set; }
		[Display(Name = "Adet")]
		public int Quantity { get; set; }
		[Display(Name = "Stokta Var Mı ?")]
		public bool IsInStock { get; set; }
		[Display(Name = "Yayında mı ?")]
		public bool IsPublished { get; set; }
		[Display(Name = "Yeni mi ?")]
		public bool IsNew { get; set; }
		[Display(Name = "Kargo Ücreti(Şehir)")]
		public decimal ShippingPriceInCityWide { get; set; }
		[Display(Name = "Kargo Ücreti(Ülke)")]
		public decimal ShippingPriceInCountryWide { get; set; }
		[Display(Name = "Kargo Ücreti(Dünya)")]
		public decimal ShippingPriceInWorldWide { get; set; }

        [Display(Name = "Tedarikçi")]       
        public string SupplierId { get; set; }
        [Display(Name = "Tedarikçi")]
        [ForeignKey("SupplierId")]
        [StringLength(200)]
        public Supplier Supplier{ get; set; }

        [Display(Name = "Marka")]        
        public string BrandId { get; set; }
        [Display(Name = "Marka")]
        [ForeignKey("BrandId")]
        [StringLength(200)]
        public Brand Brand { get; set; }

        [Display(Name="Kategori")]
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [Display(Name="Kategori")]
        public Category Category { get; set; }

        [StringLength(200)]
        [Display(Name="Fotoğraf")]
        public string Photo { get; set; }    

		[Display(Name = "Oluşturan Kullanıcı")]
        [StringLength(200)]
        public string CreatedBy { get; set; }
		[Display(Name = "Oluşturulma Tarihi")]
		public DateTime CreateDate { get; set; }
		[Display(Name = "Güncelleyen Kullanıcı")]
        [StringLength(200)]
        public string UpdatedBy { get; set; }
		[Display(Name = "Güncellenme Tarihi")]
		public DateTime UpdateDate { get; set; }

		public virtual ICollection<CartItem> CartItems { get; set; }
	}
}
