using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetSceneOnDeath : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Collider2D _collider;

    /*void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) \*Time.deltaTime);
    }*/

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene");
        }
    }
}

