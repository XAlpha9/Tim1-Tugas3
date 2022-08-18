using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XAlpha.Temp.Shoot
{
    public class TempProjectileSpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject Projectile;
        [SerializeField]
        private GameObject players;
        public void Shoot()
        {
            Instantiate(Projectile, new Vector2(players.transform.position.x, players.transform.position.y), Quaternion.identity,transform);
        }

        
    }
}

