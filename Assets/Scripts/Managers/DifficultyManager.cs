
using UnityEngine;
using System.Collections;

public class DifficultyManager : MonoBehaviour {

    public float obstacleSpeed;
    public float spawnInterval;

    public float difficultyModifier;

    public void IncreaseDifficulty()
    {
        spawnInterval -= difficultyModifier;
    }

    public void ResetDifficulty()
    {
        obstacleSpeed = 8;
        spawnInterval = 1;
    }
}
