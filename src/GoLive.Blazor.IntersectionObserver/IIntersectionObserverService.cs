using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoLive.Blazor.IntersectionObserver.API;

namespace GoLive.Blazor.IntersectionObserver
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
