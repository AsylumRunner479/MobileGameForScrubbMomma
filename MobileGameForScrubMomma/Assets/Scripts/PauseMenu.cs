using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public TIlt player;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTouchDown()
    {
        Time.timeScale = 1f;
        restart.SetActive(false);
        TIlt.IsDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (TIlt.IsDead == true)
        {
            Time.timeScale = 0f;
            restart.SetActive(true);
        }
        else
        {
            TIlt.IsDead = false;
        }
    }
}
