using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMovement : MonoBehaviour {
    private Vector3 inputHorizontal; // vetor de controle horizontal (3d por causa do transform)
    private Vector2 inputJump; //vetor de controle vertical

    // Objetos do Objeto player???
    private Rigidbody2D _rigidbody;
    private Collider2D _collider;
    private SpriteRenderer _sprite;
    private Animator _animator;

    // variaveis de controle
    private bool isJumping;
    private bool doubleJump;

    // variaveis de config
    [SerializeField] private float speed=5f;
    [SerializeField] private float jumpForce;
    [SerializeField] private float doubleJumpForce;

    private void Start() // inicia no carregamento
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
        _sprite = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();

        // variaveis de controle da animação
        _animator.SetBool("run",false);
        _animator.SetBool("jump",false);
        _animator.SetBool("fall",false);
        _animator.SetBool("double_jump",false);
        _animator.SetBool("stoped",true);
    }

    private void Update() // atualiza a cada frame
    {
        inputHorizontal.x = Input.GetAxisRaw("Horizontal"); // input horizontal
        
        Flip(inputHorizontal);
        Move(inputHorizontal);
        Jump();

        // Controle das variaveis de animacao
        if(_rigidbody.velocity.y>0)
        {
            _animator.SetBool("jump",true);
            _animator.SetBool("fall",false);
            _animator.SetBool("stoped",false);
        }    
        else if(_rigidbody.velocity.y<0) 
        {
            _animator.SetBool("jump",false);
            _animator.SetBool("fall",true);
            _animator.SetBool("double_jump",false);
            _animator.SetBool("stoped",false);
        }

        if(_rigidbody.velocity.x==0&&_rigidbody.velocity.y==0)
        {
            _animator.SetBool("fall",false);
            _animator.SetBool("stoped",true);
        }
    }

    public void Move(Vector3 input) // Movimentação 
    {
        transform.position+=speed*input*Time.deltaTime;
        _animator.SetBool("run",false);
        if(input.x!=0) _animator.SetTrigger("run");
    }

    public void Jump() // Metodo de pulo
    {
        if(Input.GetButtonDown("Jump"))
        {
            
            if(!isJumping)
            {
                inputJump.x=0f;
                inputJump.y=jumpForce;
                _rigidbody.AddForce(inputJump,ForceMode2D.Impulse);
                doubleJump = true;
            }
            else if(doubleJump)
            {
                _animator.SetBool("double_jump",true);

                inputJump.x=0f;
                inputJump.y=doubleJumpForce;
                _rigidbody.AddForce(inputJump,ForceMode2D.Impulse);
                doubleJump = false;
            }
        }
    }

    // Identifica se o player está virado para a direita ou esquerda
    public void Flip(Vector3 input)
    {
        if(input.x>0) _sprite.flipX = false;
        else if(input.x<0) _sprite.flipX = true;
    }


    // Identifica se o player está no chão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==6) isJumping=false; // significa que o player está no chão
    }

    private void OnCollisionExit2D(Collision2D collision) 
    {
        if(collision.gameObject.layer==6) isJumping=true; // significa que ele não está no chão
    }
    //

}