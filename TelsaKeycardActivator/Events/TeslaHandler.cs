using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace TelsaKeycardActivator.Events
{


    class TeslaHandler
    {
        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.HasItem(ItemType.KeycardO5) || ev.Player.HasItem(ItemType.KeycardNTFCommander) || ev.Player.HasItem(ItemType.KeycardFacilityManager) || ev.Player.HasItem(ItemType.KeycardGuard) || ev.Player.HasItem(ItemType.KeycardNTFLieutenant) || ev.Player.HasItem(ItemType.KeycardNTFOfficer))
            {
                ev.IsTriggerable = false;
            }
        }
    }
}
