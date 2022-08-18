using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Module.Projectile
{
    public class ProjectileModel : BaseModel, IProjectileModel
    {
        public GameObject PlayerProj { get; private set; }
        public GameObject EnemyProj { get; private set; }
        public GameObject PoweredUpProj { get; private set; }
        public GameObject Players { get; private set; }
        public float ProjectileY { get; private set; }

        public void SetY(float projectileY)
        {
            ProjectileY = projectileY;
            SetDataAsDirty();
            Debug.Log("x: " + ProjectileY);
        }

    }
}

