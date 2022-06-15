using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kill_monter : MonoBehaviour
{
    // Start is called before the first frame update
    public static int diemTong = 0;
    public GameObject diemText;
    public GameObject PScoin;
    public GameObject gameOverButton;
    public GameObject gameOverText;
    void Start()
    {
        CongDiem(0);
    }

    // Update is called once per frame
    void Update()
    {
        
        diemText.GetComponent<Text>().text = "Diem: " + diemTong.ToString();
    }
    public void CongDiem(int diemCong)
    {
        diemTong += diemCong;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string nam = collision.attachedRigidbody.gameObject.name;
        if(collision.gameObject.tag == "ben_trai")
        {
            Destroy(GameObject.Find("Player"));
            gameOverButton.SetActive(true);
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
        if(collision.gameObject.tag == "ben_tren")
        {
            CongDiem(3);
            Destroy(GameObject.Find(nam));
        }
        if(collision.gameObject.tag == "coinne")
        {
            CongDiem(1);
            Destroy(GameObject.Find("Mushroom_1"));
            Instantiate(PScoin, collision.gameObject.transform.position, collision.gameObject.transform.localRotation);
        }
    }
}
