using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    GameObject player;
    Vector3 dir;
    public GameObject explosionFactory;
    private void OnCollisionEnter(Collision other){
        GameObject explosion = Instantiate(explosionFactory);
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        sm.currentScore++;
        sm.currentScoreUI.text = "현재점수 (20195298 박준용) : " + sm.currentScore;
        if(sm.currentScore > sm.bestScore)
        {
            sm.bestScore = sm.currentScore;
            sm.bestScoreUI.text = "최고점수 (20195298 박준용) : " + sm.bestScore;
            PlayerPrefs.SetInt("Best Score",sm.bestScore);
        }
        explosion.transform.position = transform.position;
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
    void Start()
    {
        Vector3 dir;
        int randValue = UnityEngine.Random.Range(0,10);
        if(randValue<3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else{
            dir = Vector3.down;
        }
    }
    void Update(){
    
        transform.position += dir * speed * Time.deltaTime;
    }
   
}
