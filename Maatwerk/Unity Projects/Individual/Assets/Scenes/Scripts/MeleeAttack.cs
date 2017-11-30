using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public int Damage;
    public GameObject BloodParticles;
    public Transform ImpactPoint;
    public GameObject DamageNumbers;

    // Use this for initialization
    public void Start()
    {
		
	}

    // Update is called once per frame
    public void Update()
    {

	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealth>().ReceiveDamage(Damage);
            Instantiate(BloodParticles, ImpactPoint.position, ImpactPoint.rotation);
            var cloneNumbers = Instantiate(DamageNumbers, ImpactPoint.position, Quaternion.Euler(Vector3.zero));
            cloneNumbers.GetComponent<DamageNumbers>().DamageNumber = Damage;
        }
    }
}