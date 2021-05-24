using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _2_CSharpCollections2
{
    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare([AllowNull] string x, [AllowNull] string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}