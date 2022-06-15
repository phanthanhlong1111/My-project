using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinne : MonoBehaviour
{
    // Start is called before the first frame update
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
        Debug.Log(1);
            kill_monter.diemTong += 1;
            Destroy(transform.gameObject);
        }
    }
}
