using Interfaces;
using MVP.Models;
using MVP.Presenters;
using MVP.Views;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameObject[] planets;
        [SerializeField] private SpawnView spawnView;
        [SerializeField] private MergeView mergeView;
        [SerializeField] private GameView gameView;
        
        // ReSharper disable Unity.PerformanceAnalysis
        public override void InstallBindings()
        {
            Container.Bind<ISpawnerService>().To<SpawnerService>().AsSingle().WithArguments(planets);
            Container.Bind<IMergeService>().To<MergeService>().AsSingle();
            Container.Bind<IScoreService>().To<ScoreService>().AsSingle().WithArguments(11);
            
            Container.Bind<IView>().To<SpawnView>().FromInstance(spawnView).AsSingle();
            Container.Bind<MergeView>().FromInstance(mergeView).AsSingle();
            Container.Bind<GameView>().FromInstance(gameView).AsSingle();
            
            Container.Bind<SpawnPresenter>().AsSingle();
            Container.Bind<MergePresenter>().AsSingle();
            Container.Bind<GamePresenter>().AsSingle();
        }
    }
}