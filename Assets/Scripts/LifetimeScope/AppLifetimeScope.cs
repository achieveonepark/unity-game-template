using VContainer;
using VContainer.Unity;

namespace Achieve.Game
{
    public class AppLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PlayerData>(Lifetime.Singleton);
            builder.RegisterEntryPoint<AppStartPoint>();
        }

        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }
    }
}