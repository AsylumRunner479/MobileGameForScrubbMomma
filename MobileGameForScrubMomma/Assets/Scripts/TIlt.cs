using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIlt : MonoBehaviour
{
    public bool IsDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsDead == false)
        {
            transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            IsDead = true;
        }
        
    }
}
