using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healtBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
            Debug.Log(currentHealth);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healtBar.SetHealth(currentHealth);
    }

}
