using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IInput>().To<DesktopInput>().FromNew().AsTransient();
        //Container.Bind<MovementComponent>().FromNew().AsSingle().NonLazy();
    }
}
