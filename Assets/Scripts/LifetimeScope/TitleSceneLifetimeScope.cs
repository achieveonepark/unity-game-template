using VContainer;
using VContainer.Unity;

namespace Achieve.Game
{
    public class TitleSceneLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PlayerData>(Lifetime.Singleton);
            builder.RegisterEntryPoint<TitleSceneStartPoint>();
        }

        public LifetimeScope Parent => LifetimeScope.Find<AppLifetimeScope>();
    }
}