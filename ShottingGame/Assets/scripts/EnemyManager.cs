using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime = 0;
    public float createTime = 1;
    public GameObject enemyFactory;
    float minTime = 1;
    float maxTime = 5;
    public float speed = 5;
    Vector3 dir;
    

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    void Update(){
        currentTime += Time.deltaTime;
        dir = Vector3.down;

        if(currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            enemy.transform.position += dir * speed * Time.deltaTime;
            createTime = UnityEngine.Random.Range(minTime, maxTime);
            currentTime = 0;
            
        }
    }
}
