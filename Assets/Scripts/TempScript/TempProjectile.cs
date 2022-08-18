using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempProjectile : MonoBehaviour
{
    [SerializeField]
    private Vector2 ProjSpd;
    private Rigidbody2D ProjRig;
    // Start is called before the first frame update
    void Start()
    {
        ProjRig = GetComponent<Rigidbody2D>();
        ProjRig.velocity = ProjSpd;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
