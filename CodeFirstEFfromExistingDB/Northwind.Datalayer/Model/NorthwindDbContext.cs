using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessLayer
{
    /// <summary>Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
    /// <filterpriority>1</filterpriority>
    public partial class NorthwindDbContext
    {
        public int GetSaveChangesCount()
        {
            return SaveChangesCount;
        }
    }
}
