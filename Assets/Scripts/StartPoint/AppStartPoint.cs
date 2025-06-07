using GameFramework;
using VContainer.Unity;

namespace Achieve.Game
{
    public class AppStartPoint : IStartable
    {
        public void Start()
        {
            SceneManager.LoadScene("01.Title");
        }
    }
}