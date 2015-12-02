using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Events;
using Umbraco.Core.Models;

namespace Umbraco.Core.Publishing {
    public static class AtgMoetPublishedContent {
        public static event TypedEventHandler<object, AtgMoetPublishedContentChangedEventArgs<IContent>> PublishedContentChanged;
        public static void RaiseEvent(object sender, AtgMoetPublishedContentChangedEventArgs<IContent> eventArgs) {
            if (PublishedContentChanged != null) {
                PublishedContentChanged( sender, eventArgs );
            }
        }
    }
}
