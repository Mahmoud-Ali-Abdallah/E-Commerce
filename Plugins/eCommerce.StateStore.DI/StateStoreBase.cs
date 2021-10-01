using eCommerce.UseCases.PluginInterfaces.StateStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.StateStore.DI
{
    public class StateStoreBase : IStateStore
    {
        protected Action listeners;

        public void AddStateChangeListeners(Action listener) => this.listeners += listener;

        public void RemoveStateChangeListeners(Action listener) => this.listeners -= listener;

        public void BroadCastStateChange()
        {
            if (listeners != null)
                listeners.Invoke();
        }


    }
}
