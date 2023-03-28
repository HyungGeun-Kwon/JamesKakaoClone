using Prism.DryIoc;
using Prism.Modularity;
using System.Collections.Generic;

namespace Kakao1.Helper
{
    internal abstract class PrismApplicationHelper : PrismApplication
    {
        private List<IModule> _modules = new List<IModule>();

        public PrismApplicationHelper AddInversionModule<T>() where T : IModule, new()
        {
            IModule item = new T();
            _modules.Add(item);
            return this;
        }

        public PrismApplicationHelper WireViewViewModel<T>() where T : IViewViewModelWire, new()
        {
            new T().WireVVM();
            return this;
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            foreach (IModule item in _modules)
            {
                moduleCatalog.AddModule(item.GetType());
            }
        }
    }
}