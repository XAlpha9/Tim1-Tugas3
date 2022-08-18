using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Module.Projectile
{
    public class ProjectileController : ObjectController<ProjectileController, ProjectileModel, IProjectileModel, ProjectileView>
    {
        protected GameObject PlayerProj { get; private set; }
        protected GameObject EnemyProj { get; private set; }
        protected GameObject PoweredUpProj { get; private set; }
        public GameObject Player { get; private set; }


    }
}

