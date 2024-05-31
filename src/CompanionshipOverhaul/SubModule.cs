using CompanionshipOverhaul.Extensions;

using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;


namespace CompanionshipOverhaul
{
    public class SubModule : MBSubModuleBase
    {
        private const string SLoaded = "{=}Loaded Companionship Overhaul!";

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage(SLoaded.ToLocalizedString(), Color.FromUint(4282569842U)));
        }
    }
}