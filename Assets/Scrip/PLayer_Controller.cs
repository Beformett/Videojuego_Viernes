using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Animations;

public class PLayer_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Caminar", true);
            rb.linearVelocityX = 5;
             sr.flipX = false;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)){
            anim.SetBool("Caminar", false);
            rb.linearVelocityX = 0;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Caminar", true);
            sr.flipX = true;
            rb.linearVelocityX = -5;
        }
         if (Input.GetKeyUp(KeyCode.LeftArrow)){
            anim.SetBool("Caminar", false);
            rb.linearVelocityX = 0;
        }

    }
}
