using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
	public Transform[] spawnPos;
	public GameObject[] enemyPrefab;
	public int enemyFinder;
	public int enemyCount;
	public int wave = 1;
	public bool canSpawn;
	public int maxWave;
	int _pos;
	int _enemyType;
	// Start is called before the first frame update
	void Start()
	{
		//enemyCount = 2;
		EnemySpawner(enemyCount);
		canSpawn = true;

	}

	// Update is called once per frame
	void Update()
	{
		//_pos = Random.Range(0,4);
		//_enemyType = Random.Range(0,3);
		enemyFinder = FindObjectsOfType<AIEnemy>().Length;

		if (enemyFinder == 0 && canSpawn == true)
		{
			enemyCount += 2;
			EnemySpawner(enemyCount);
			wave++;
		}
		if (wave == 5)
		{
			enemyCount = 5;
		}
		if (enemyFinder == 0 && wave == maxWave)
		{
			canSpawn = false;
		}
	}

	void EnemySpawner(int enemyspawned)
	{
		for (int i = 0; i < enemyspawned; i++)
		{

			_pos = Random.Range(0, 4);

			if (wave == 1)
			{
				_enemyType = 0;
			}
			else if (wave < 4 && wave > 1)
			{
				_enemyType = 0;
			}
			else if (wave == 5)
			{
				_enemyType = 0;
			}


			Instantiate(enemyPrefab[_enemyType], spawnPos[_pos].transform.position, spawnPos[_pos].transform.rotation);
		}
	}
}
