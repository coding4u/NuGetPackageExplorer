using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PackageExplorerViewModel
{
    internal interface IQueryContext<T>
    {
        int BeginPackage { get; }
        int EndPackage { get; }
        bool IsLastPage { get; }

        Task<IList<T>> GetItemsAsync(CancellationToken token);

        bool MoveNext();
    }
}
