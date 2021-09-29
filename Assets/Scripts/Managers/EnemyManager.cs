using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    [SerializeField]
    MonoBehaviour factory;
    IFactory Factory{get{return factory as IFactory;}}

    // Start is called before the first frame update
    void Start()
    {
        //Mengeksekusi fungsi spawn setiap beberapa detik sesuai dengan nilai spawnTime
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        //Jika player telah mati maka tidak membuat enemy baru
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        //Mendapatkan nilai random
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int spawnEnemy = Random.Range(0, 3);


        //duplicate enemies
        //Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation)
        Factory.FactoryMethod(spawnEnemy);
    }
}
