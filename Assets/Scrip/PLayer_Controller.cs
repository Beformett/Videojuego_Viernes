using UnityEngine;
using UnityEngine.Animations;

public class PLayer_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform trans;
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;
    void Start()
    {
        trans = GetComponent<Transform>();
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
        }
        rb.linearVelocityX = 0;
        anim.SetBool("Caminar",false);
    }
}
