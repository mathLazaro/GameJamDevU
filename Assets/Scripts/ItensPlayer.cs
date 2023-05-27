using UnityEngine;

public class ItensPlayer : MonoBehaviour {
    private Collider2D _collider;
    private void Start() {
        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.gameObject.tag=="Fruit") Debug.Log("a");
    }
}