using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events;
using TelsaKeycardActivator.Events;

namespace TeslaKeycardActivator { 

    public class TeslaKeycardActivator : Plugin<Config>
    {

        private static TeslaKeycardActivator Singleton;
        public static TeslaKeycardActivator Instance => Singleton;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private TeslaHandler teslaHandler;

        public override void OnEnabled()
        {
            RegisterEvents();
            Log.Info("Plugin has been enabled.");
            Singleton = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            unRegisterEvents();
            Singleton = null;
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            teslaHandler = new TeslaHandler();

            Exiled.Events.Handlers.Player.TriggeringTesla += teslaHandler.OnTriggeringTesla;
        }
        
        private void unRegisterEvents()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= teslaHandler.OnTriggeringTesla;
        }
    }
}