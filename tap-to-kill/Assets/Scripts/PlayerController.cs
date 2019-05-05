using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private RaycastHit2D hit2d;
    private Vector3 mousePosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touch();
        }
        if (GameManager.gm.IsEnd)
        {
            Destroy(gameObject);
        }
    }

    protected void touch()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit2d = Physics2D.Raycast(mousePosition, transform.TransformDirection(Vector2.up));
        if (hit2d.collider != null)
        {
            hit2d.transform.gameObject.SendMessage("hit");
        }
    }
}
