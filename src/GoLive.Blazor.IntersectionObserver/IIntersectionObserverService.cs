using Ljbc1994.Blazor.IntersectionObserver.API;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ljbc1994.Blazor.IntersectionObserver
{
    public interface IIntersectionObserverService
    {
        Task<IntersectionObserver> Create(
            Func<IList<IntersectionObserverEntry>, ValueTask> onIntersectUpdate,
            IntersectionObserverOptions options = null
        );

        Task<IntersectionObserver> Observe(
           ElementReference element,
           Func<IList<IntersectionObserverEntry>, ValueTask> onIntersectUpdate,
           IntersectionObserverOptions options = null
       );

       Task OnCallback(string id, IList<IntersectionObserverEntry> entries);
    }
}
