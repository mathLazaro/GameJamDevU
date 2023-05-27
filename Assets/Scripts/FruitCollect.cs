using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollect : MonoBehaviour
{
    private CircleCollider2D circle;
    private Animator animator;

    public int score;

    void Start()
    {
        circle = GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.gameObject.tag=="Player")
        {
            animator.SetBool("collected",true);
            
            GameController.instance.totalScore+=score;
            GameController.instance.UpdateScoreText();
            
            Destroy(gameObject,0.5f);
        }
    }
}


