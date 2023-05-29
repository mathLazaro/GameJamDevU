using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlataform : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float delay;

    private void Start() {
        _rigidbody=GetComponent<Rigidbody2D>();
    }
    IEnumerator Fall()
    {
        yield return new WaitForSeconds(0.0001f);
        _rigidbody.bodyType=RigidbodyType2D.Dynamic;
        Destroy(gameObject,delay);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Player")){
            StartCoroutine(Fall());
        }
    }
}
