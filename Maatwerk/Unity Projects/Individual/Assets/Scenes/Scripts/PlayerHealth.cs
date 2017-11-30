using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;

    // Use this for initialization
    // the player starts with his current health as his max
    public void Start()
    {
        CurrentHealth = MaxHealth;
	}

    // Update is called once per frame
    // if the players health <0 the player dissapears
    public void Update()
    {
        if (CurrentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
	}

    // calculates current health while the player takes damage
    public void ReceiveDamage(int damage)
    {
        CurrentHealth -= damage;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
