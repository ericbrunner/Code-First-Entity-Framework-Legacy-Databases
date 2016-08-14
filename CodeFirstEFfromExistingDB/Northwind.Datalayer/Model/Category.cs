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

    // Categories
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class Category
    {
        public int CategoryId { get; set; } // CategoryID (Primary key)
        public string CategoryName { get; set; } // CategoryName (length: 15)
        public string Description { get; set; } // Description (length: 1073741823)
        public byte[] Picture { get; set; } // Picture (length: 2147483647)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Product> Products { get; set; } // Products.FK_Products_Categories

        public Category()
        {
            Products = new System.Collections.Generic.List<Product>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
