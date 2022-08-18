using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XAlpha.Temp.Shoot;

public class TempPlayerControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;
    public KeyCode LeftKey, RightKey, ShootKey;
    private Rigidbody2D rig;
    [SerializeField]
    private TempProjectileSpawner TempProjectileSpawner;
    private float Times;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Times > 0)
        {
            Times -= Time.deltaTime;  
        }
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(LeftKey))
        {
            return Vector2.left * speed;
        }
        if (Input.GetKey(RightKey))
        {
            return Vector2.right * speed;
        }
        if (Input.GetKeyDown(ShootKey))
        {
            if (Times <= 0)
            {
                TempProjectileSpawner.Shoot();
                Times = 0.3f;
            }
            else
            {
                Debug.Log("On CD!");
            }
            
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
}
