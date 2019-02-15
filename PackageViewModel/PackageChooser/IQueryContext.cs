using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PackageExplorerViewModel
{
    internal interface IQueryContext<T>
    {
        bool IsLastPage { get; }

        Task<IList<T>> GetItemsAsync(CancellationToken token);

        bool MoveNext();
    }
}
