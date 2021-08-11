using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    float scaleUp = 0.01f;
    public bool foodIsDestroy = false;
    public int scorePoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "food")
        {
            Debug.Log("Kmu Makan");
            GameObject.Destroy(collision.gameObject);
            transform.localScale = new Vector2(transform.localScale.x + scaleUp, transform.localScale.y + scaleUp);
            foodIsDestroy = true;
            scorePoint += 1;
        }
    }
}
