using Rts.EntryPoint.Scenarios;
using Rts.Extensions;
using Zenject;

namespace Rts.EntryPoint
{
    public class EntryPointInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindScenario<EntryPointScenario>();
        }
    }
}