using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int Damage; 

    // Use this for initialization
    public void Start()
    {
		
	}

    // Update is called once per frame
    public void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().ReceiveDamage(Damage);
        }
    }
}
