using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rig;
    Animator anim;
    public int vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Morte();
    }
    void Move()
    {
        rig.velocity = new Vector2(Input.GetAxis("Horizontal") * speed);
        rig.velocity = new Vector2(Input.GetAxis("Vertical") * speed);
    }
    void Morte()
    {
        if(vida == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
