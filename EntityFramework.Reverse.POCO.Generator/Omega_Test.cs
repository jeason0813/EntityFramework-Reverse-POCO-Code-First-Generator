// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_Reverse_POCO_Generator
{

    // The table 'Test' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // Test
    [NotMapped]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Omega_Test
    {
        [Column("Id", Order = 1, TypeName = "int")]
        [Display(Name = "Id")]
        public int? Id { get; set; } // Id

        [Column("ExclusionTest", Order = 2, TypeName = "int")]
        [Display(Name = "Exclusiontest")]
        public int? ExclusionTest { get; set; } // ExclusionTest
    }

}
// </auto-generated>
