using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderScore : MonoBehaviour
{
    public bool hit, miss;
    public int BoyFriend_Kissing_kiss_count = 0;
    public bool miss_chance = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Boyfriend_task()
    {
        FindGirl();
    }
    void FindGirl()
    {
        if (miss == false && hit == false)
        {
            
            miss = true;
            hit = false;
        }
        else if (hit == false && miss == true)
        {
            
            miss = false;
            hit = true;
            BoyFriend_Kissing_kiss_count += 1;
            Debug.Log("That_dab");
        }
        else if (hit == true && miss == false)
        {
            
            miss = true;
            hit = true;
        }
        else
        {
            
            miss = false;
            hit = false;
            Debug.Log(BoyFriend_Kissing_kiss_count);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Boyfriend_task();



    }
}
