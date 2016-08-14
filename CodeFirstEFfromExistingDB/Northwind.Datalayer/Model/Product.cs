// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.61
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace Northwind.DataAccessLayer
{

    // Products
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class Product
    {
        public int ProductId { get; set; } // ProductID (Primary key)
        public string ProductName { get; set; } // ProductName (length: 40)
        public int? SupplierId { get; set; } // SupplierID
        public int? CategoryId { get; set; } // CategoryID
        public string QuantityPerUnit { get; set; } // QuantityPerUnit (length: 20)
        public decimal? UnitPrice { get; set; } // UnitPrice
        public short? UnitsInStock { get; set; } // UnitsInStock
        public short? UnitsOnOrder { get; set; } // UnitsOnOrder
        public short? ReorderLevel { get; set; } // ReorderLevel
        public bool Discontinued { get; set; } // Discontinued

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<OrderDetail> OrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Category Category { get; set; } // FK_Products_Categories
        public virtual Supplier Supplier { get; set; } // FK_Products_Suppliers

        public Product()
        {
            UnitPrice = 0m;
            UnitsInStock = 0;
            UnitsOnOrder = 0;
            ReorderLevel = 0;
            Discontinued = false;
            OrderDetails = new System.Collections.Generic.List<OrderDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
