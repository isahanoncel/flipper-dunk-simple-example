using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Vector3 startPos;
    void Start()
    {
        startPos=this.gameObject.transform.position;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("end"))
        {
            resetBallPosition();
        }
        else if(col.gameObject.tag.Equals("Target") && gameObject.GetComponent<Rigidbody2D>().velocity.y<-0.1)
        {
            GameObject.Find("Manager").GetComponent<gameManager>().generateNewPota();
            GameObject.Find("Manager").GetComponent<AudioSource>().Play();
            Destroy(col.gameObject,0f);
            resetBallPosition();
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag!="Player")
        {
        this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
    void resetBallPosition()
    {
         this.gameObject.transform.position=startPos;
        this.gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);

    }
}
