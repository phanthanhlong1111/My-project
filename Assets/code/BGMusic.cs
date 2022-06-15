using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public static BGMusic bgmusic;

    void Awake()
    {
        if(bgmusic != null && bgmusic != this)
        {
            Destroy(this.gameObject);
            return;
        }
        bgmusic = this;
        DontDestroyOnLoad(this);
    }

}
