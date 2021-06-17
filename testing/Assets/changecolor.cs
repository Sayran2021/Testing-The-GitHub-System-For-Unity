using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public GameObject circle;

    private SpriteRenderer thething;

    private void Start() {
       thething = circle.GetComponent<SpriteRenderer>();
    }

    public void ChangeColor()
    {
        thething.color = Color.green;
    }
}
