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
    using Northwind.DataAccessLayer.Model.Context;
    using Northwind.DataAccessLayer.Model.Interfaces;

    // Summary of Sales by Year
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class SummaryOfSalesByYear
    {
        public System.DateTime? ShippedDate { get; set; } // ShippedDate
        public int OrderId { get; set; } // OrderID
        public decimal? Subtotal { get; set; } // Subtotal

        public SummaryOfSalesByYear()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
