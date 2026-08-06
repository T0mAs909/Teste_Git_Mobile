using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] Enemy enemy1;
    void Start()
    {
        print(enemy1.life);
        print(enemy1.enemyName);
        print(enemy1.height);
    }

    void Update()
    {
        
    }
}
