using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject tile;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
            timer += Time.deltaTime;
        else 
        {
            spawnPipe();
        }

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    public void spawnPipe()
    {
        Instantiate(tile, transform.position, transform.rotation);
        timer = Random.Range(0, 1);
    }
    
}
