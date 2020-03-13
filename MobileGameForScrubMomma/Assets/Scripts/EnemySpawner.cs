using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float Timer = 10;
    public GameObject Enemy;
    public GameObject CurEnemy;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            CurEnemy = Instantiate(Enemy);
            CurEnemy.transform.position = new Vector3(Random.Range(-9, 9), Random.Range(-5, 5), 0);
            rb = CurEnemy.GetComponent<Rigidbody>();
            rb.AddForce(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
            Timer += 5;
        }
    }
}
