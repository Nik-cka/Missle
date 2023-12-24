using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print ("Здоровье игрока: " + health);

    }

    private void Update()
    {
       if (Input.GetMouseButton(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
