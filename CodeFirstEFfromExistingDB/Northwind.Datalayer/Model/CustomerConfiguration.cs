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

    // Customers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class CustomerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
            : this("dbo")
        {
        }

        public CustomerConfiguration(string schema)
        {
            ToTable("Customers", schema);
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName(@"CustomerID").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyName).HasColumnName(@"CompanyName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.ContactName).HasColumnName(@"ContactName").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.ContactTitle).HasColumnName(@"ContactTitle").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.City).HasColumnName(@"City").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Region).HasColumnName(@"Region").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Country).HasColumnName(@"Country").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(24);
            Property(x => x.Fax).HasColumnName(@"Fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(24);
            HasMany(t => t.CustomerDemographics).WithMany(t => t.Customers).Map(m =>
            {
                m.ToTable("CustomerCustomerDemo", "dbo");
                m.MapLeftKey("CustomerID");
                m.MapRightKey("CustomerTypeID");
            });
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>