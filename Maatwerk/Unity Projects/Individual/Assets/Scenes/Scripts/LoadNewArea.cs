using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNewArea : MonoBehaviour
{
    public string sceneToLoad;

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
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
