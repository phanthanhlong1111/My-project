using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiChuyen : MonoBehaviour
{
    public Animator ani;
    public bool isRight = true;
    public bool nen_dat;
    public GameObject gameOverButton;
    public GameObject gameOverText;
    public bool isPause = false;
        // Start is called before the first frame update
    void Awake()
    {
      
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
         isRight = true;   
        ani.SetBool("isRunning", true); 
        ani.Play("Running");
        transform.Translate(Time.deltaTime * 40,0,0);
        transform.localScale = new Vector3 ( 8F, 8F, 8F);
        }
        if(Input.GetKey(KeyCode.A))
        {
        isRight= false;
        ani.SetBool("isRunning", true); 
        ani.Play("Running");
        transform.Translate(-Time.deltaTime * 40 ,0,0);
        transform.localScale = new Vector3 ( -8F, 8F, 8F);  
        }
        if(Input.GetKey(KeyCode.W) )
        {
            if (nen_dat == true)
            {
              if(isRight == true)
              {
                transform.Translate(Time.deltaTime * 50, 30.0f, 0);
              }
              else
              {
              transform.Translate(-Time.deltaTime * 50, 30.0f, 0);
              }
              nen_dat = false;
            }
            
       
        }
        if(Input.GetKey(KeyCode.P))
        {
            isPause = !isPause;
            if(isPause)
            {
                Time.timeScale = 0;
                
            }else
            {
                Time.timeScale = 1;
               
            }
        }

    }
     private void OnCollisionEnter2D(Collision2D collision)
     {
        if(collision.gameObject.tag == "nen_dat")
        {
            nen_dat = true;
        }
        if(collision.gameObject.tag == "qua_man")
        {
            SceneManager.LoadScene("trang_3");  
        }
        
     }
     private void OnTriggerEnter2D(Collider2D collision)
     {
        if (collision.gameObject.tag == "Roi_xuong")
        {
            gameOverButton.SetActive(true);
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
     }
}
