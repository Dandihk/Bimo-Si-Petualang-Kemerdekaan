using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_hit_emeny : MonoBehaviour
{

    public LayerMask layer_enemy;//
    public Transform posisi;
    public float panjang_raycast_enemy;
    public ParticleSystem dust_enemy;

    void Update()
    {

        RaycastHit2D hit_enemy = Physics2D.Raycast(posisi.position, Vector2.down, panjang_raycast_enemy, layer_enemy);
        if (hit_enemy)///
        {
            dust_enemy.Play();
            Destroy(hit_enemy.transform.gameObject);
        }

    }

    
}
