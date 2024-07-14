using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTranslate : MonoBehaviour
{
    Vector2 move;
    [SerializeField] float speed;

    private void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       
        transform.Translate (move * speed * Time.deltaTime , Space.World  ); // Di chuyen toa do the gioi 
        //transform.Translate(move * speed * Time.deltaTime, Space.Self); // Di chuyen theo toa do nv
        flip();
    }
    void flip()
    {
        if (move.x < -0.01f) transform.localScale = new Vector3(-1, 1, 1);
        if (move.x > 0.01f) transform.localScale = new Vector3(1, 1, 1);
    }
}
