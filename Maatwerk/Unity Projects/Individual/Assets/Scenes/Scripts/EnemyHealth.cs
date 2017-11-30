using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;

	// Use this for initialization
	public void Start()
    {
        CurrentHealth = MaxHealth;
	}

    // Update is called once per frame
    public void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void ReceiveDamage(int damage)
    {
        CurrentHealth -= damage;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }

}
