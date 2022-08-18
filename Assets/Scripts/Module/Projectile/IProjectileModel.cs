using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Module.Projectile
{
    public interface IProjectileModel : IBaseModel
    {
        public float ProjectileY { get; }
    }
}

