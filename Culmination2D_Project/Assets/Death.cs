using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject deathScreen;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Player"){
            Debug.Log("Death script destroying " + other.gameObject.name);
            Destroy(other.gameObject);

            deathScreen.SetActive(true);
        }
    }
}
