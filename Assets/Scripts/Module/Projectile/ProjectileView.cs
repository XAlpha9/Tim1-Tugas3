using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;

namespace Tim1RX.SpaceInvader.Module.Projectile
{
    public class ProjectileView : ObjectView<IProjectileModel>
    {
        [SerializeField]
        private GameObject PlayerProj, EnemyProj, PoweredUpProj;
        [SerializeField]
        private GameObject Players;
        public bool isShoot = false;
        private UnityAction _ProjectileMove;

        public void Callback(UnityAction projectileMove)
        {
            _ProjectileMove = projectileMove;
        }

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
            if(isShoot == true)
            {
                Instantiate(PlayerProj, new Vector2(Players.transform.position.x, -4.2f), Quaternion.identity);
                isShoot = false;
                //Instantiate(PlayerProj, transform.position(Players.transform.position.x, 4.2f), transform);
            }

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(this.gameObject);
        }
    }

}

