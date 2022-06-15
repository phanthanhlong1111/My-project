using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_infinity : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 0.2f;
    public float offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * Speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
