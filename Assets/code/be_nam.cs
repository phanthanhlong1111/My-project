using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class be_nam : MonoBehaviour
{
    bool gioi_han;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gioi_han)
        {
            transform.Translate(Time.deltaTime *20, 0, 0);
        }
        else
        {
            transform.Translate(-Time.deltaTime * 20, 0 ,0);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "gioi_han")
        {
            gioi_han = true;
        }
    }
}
