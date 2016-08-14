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
    public partial class ProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
            : this("dbo")
        {
        }

        public ProductConfiguration(string schema)
        {
            ToTable("Products", schema);
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName(@"ProductID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasColumnName(@"ProductName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupplierId).HasColumnName(@"SupplierID").IsOptional().HasColumnType("int");
            Property(x => x.CategoryId).HasColumnName(@"CategoryID").IsOptional().HasColumnType("int");
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").IsOptional().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").IsOptional().HasColumnType("smallint");
            Property(x => x.UnitsOnOrder).HasColumnName(@"UnitsOnOrder").IsOptional().HasColumnType("smallint");
            Property(x => x.ReorderLevel).HasColumnName(@"ReorderLevel").IsOptional().HasColumnType("smallint");
            Property(x => x.Discontinued).HasColumnName(@"Discontinued").IsRequired().HasColumnType("bit");

            // Foreign keys
            HasOptional(a => a.Category).WithMany(b => b.Products).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK_Products_Categories
            HasOptional(a => a.Supplier).WithMany(b => b.Products).HasForeignKey(c => c.SupplierId).WillCascadeOnDelete(false); // FK_Products_Suppliers
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
