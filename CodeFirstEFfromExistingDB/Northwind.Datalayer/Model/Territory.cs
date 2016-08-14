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

    // Territories
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class Territory
    {
        public string TerritoryId { get; set; } // TerritoryID (Primary key) (length: 20)
        public string TerritoryDescription { get; set; } // TerritoryDescription (length: 50)
        public int RegionId { get; set; } // RegionID

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Employee> Employees { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Region Region { get; set; } // FK_Territories_Region

        public Territory()
        {
            Employees = new System.Collections.Generic.List<Employee>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
