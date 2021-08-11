using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMov;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            Camera.main.ScreenToWorldPoint(Input.mousePosition), speedMov * Time.deltaTime);
    }
}
