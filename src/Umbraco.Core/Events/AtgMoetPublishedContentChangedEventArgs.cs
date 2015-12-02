using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace Umbraco.Core.Events {
    public class AtgMoetPublishedContentChangedEventArgs<TEntity> : CancellableObjectEventArgs<IEnumerable<TEntity>> {
        /// <summary>
        /// Constructor accepting multiple entities that are used in the publish operation
        /// </summary>
        /// <param name="eventObject"></param>
        /// <param name="canCancel"></param>
        /// <param name="isAllPublished"></param>
        /// <param name="eventMessages"></param>
        public AtgMoetPublishedContentChangedEventArgs(IEnumerable<TEntity> eventObject, bool canCancel, EventMessages eventMessages)
                : base( eventObject, canCancel, eventMessages ) {
        }

        /// <summary>
        /// Constructor accepting multiple entities that are used in the publish operation
        /// </summary>
        /// <param name="eventObject"></param>
        /// <param name="eventMessages"></param>
        public AtgMoetPublishedContentChangedEventArgs(IEnumerable<TEntity> eventObject, EventMessages eventMessages)
                : base( eventObject, eventMessages ) {
        }

        /// <summary>
        /// Constructor accepting a single entity instance
        /// </summary>
        /// <param name="eventObject"></param>
        /// <param name="eventMessages"></param>
        public AtgMoetPublishedContentChangedEventArgs(TEntity eventObject, EventMessages eventMessages)
                : base( new List<TEntity> { eventObject }, eventMessages ) {
        }

        /// <summary>
        /// Constructor accepting a single entity instance
        /// </summary>
        /// <param name="eventObject"></param>
        /// <param name="canCancel"></param>
        /// <param name="isAllPublished"></param>
        /// <param name="eventMessages"></param>
        public AtgMoetPublishedContentChangedEventArgs(TEntity eventObject, bool canCancel, EventMessages eventMessages)
                : base( new List<TEntity> { eventObject }, canCancel, eventMessages ) {
        }

        /// <summary>
        /// Constructor accepting multiple entities that are used in the publish operation
        /// </summary>
        /// <param name="eventObject"></param>
        /// <param name="canCancel"></param>
        /// <param name="isAllPublished"></param>
        public AtgMoetPublishedContentChangedEventArgs(IEnumerable<TEntity> eventObject, bool canCancel)
                : base( eventObject, canCancel ) {
        }

        /// <summary>
        /// Constructor accepting multiple entities that are used in the publish operation
        /// </summary>
        /// <param name="eventObject"></param>
        public AtgMoetPublishedContentChangedEventArgs(IEnumerable<TEntity> eventObject)
                : base( eventObject ) {
        }

        /// <summary>
        /// Constructor accepting a single entity instance
        /// </summary>
        /// <param name="eventObject"></param>
        public AtgMoetPublishedContentChangedEventArgs(TEntity eventObject)
                : base( new List<TEntity> { eventObject } ) {
        }

        /// <summary>
        /// Returns all entities that were published during the operation
        /// </summary>
        public IEnumerable<TEntity> PublishedEntities {
            get { return EventObject; }
        }

        public PublishedState PublishedState { get; set; }
    }
}