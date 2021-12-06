using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace CoverletDoesNotReturn
{
    public class Helper
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentException(string paramName, string? message)
            => throw new ArgumentException(message, paramName);

    }
}
