using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Animator anim;
    public bool canDoThings = true;
    public float forwardMove = 0;
    public float horizontalMove = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (canDoThings)
        {
            horizontalMove = Input.GetAxis("Horizontal");
            anim.SetFloat("Turn", horizontalMove);

            forwardMove = Input.GetAxis("Vertical");
            anim.SetFloat("Forward", forwardMove);
        }
    }
}
