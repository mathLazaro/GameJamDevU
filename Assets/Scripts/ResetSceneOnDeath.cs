using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetSceneOnDeath : MonoBehaviour
{
    //private Rigidbody2D _rigidbody;
    private Collider2D _collider;

    /*void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) \*Time.deltaTime);
    }*/

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene");
        }
    }
}

