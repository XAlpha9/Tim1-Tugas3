using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Tim1RX.SpaceInvader.Module.Projectile
{
    public class ProjectileView : ObjectView<IProjectileModel>
    {
        [SerializeField]
        private GameObject PlayerProj, EnemyProj, PoweredUpProj;
        [SerializeField]
        private GameObject Players;
        public bool isShoot = false;

        protected override void InitRenderModel(IProjectileModel model)
        {
            PlayerProj.transform.SetPositionAndRotation(new Vector2(_model.ProjectileY, -4.2f), Quaternion.identity);
            EnemyProj.transform.SetPositionAndRotation(new Vector2(_model.ProjectileY, -4.2f), Quaternion.identity);
            PoweredUpProj.transform.SetPositionAndRotation(new Vector2(_model.ProjectileY, -4.2f), Quaternion.identity);
        }

        protected override void UpdateRenderModel(IProjectileModel model)
        {
            PlayerProj.transform.SetPositionAndRotation(new Vector2(_model.ProjectileY, -4.2f), Quaternion.identity);
            EnemyProj.transform.SetPositionAndRotation(new Vector2(_model.ProjectileY, -4.2f), Quaternion.identity);
            PoweredUpProj.transform.SetPositionAndRotation(new Vector2(_model.ProjectileY, -4.2f), Quaternion.identity);
        }

        void Update()
        {
            //Instantiate(PlayerProj, new Vector2(Players.transform.position.x, -4.2f))
            //Instantiate(PlayerProj, transform.position(Players.transform.position.x, 4.2f), transform);
        }
    }

}

