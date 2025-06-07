using GameFramework;
using UnityEngine;
using VContainer.Unity;

namespace Achieve.Game
{
    public class TitleSceneStartPoint : IStartable
    {
        readonly PlayerData _playerData;
        
        public TitleSceneStartPoint(PlayerData playerData)
        {
            _playerData = playerData;
        }
        
        public async void Start()
        {
            _playerData.GetType();
            Debug.Log("TitleScene Start.");
        }
    }
}