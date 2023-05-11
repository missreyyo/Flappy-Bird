using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public float maxSpawnTime = 1;
    public float timer = 0;
    public GameObject pipe;
    public float  high;
    
    void Start(){
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-high, high), 0);
    }
    void Update()
    {
        if(timer> maxSpawnTime)
        {
             GameObject newPipe = Instantiate(pipe);
             newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-high, high), 0);
             Destroy(newPipe, 15);
             timer = 0;
        }
        timer += Time.deltaTime;
    }
}
