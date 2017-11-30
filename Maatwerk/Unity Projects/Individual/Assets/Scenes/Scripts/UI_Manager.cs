using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Slider HPbar;
    public Text HPinfo;
    public PlayerHealth PlayerHealth;

    private static bool playerExisting;

    // Use this for initialization
    void Start()
    {
        if (playerExisting == false)
        {
            playerExisting = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update()
	{
	    HPbar.maxValue = PlayerHealth.MaxHealth;
	    HPbar.value = PlayerHealth.CurrentHealth;
	    HPinfo.text = "HP: " + PlayerHealth.CurrentHealth + "/" + PlayerHealth.MaxHealth;
	}
}
