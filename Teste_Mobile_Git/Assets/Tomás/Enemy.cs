using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/EnemySO")]
public class Enemy : ScriptableObject
{
    public int life;
    public string enemyName;
    public float height;
}