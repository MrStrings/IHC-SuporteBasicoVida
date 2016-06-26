using UnityEngine;
using System.Collections;

public class SideSpawner : MonoBehaviour {

	public GameObject prefab;
	public float[] positionsVertical;
	public float horizontalBounds;
	public float timeOfFirstSpawn = 10;
	public float timeBetweenSpawns;

	float timeOfLastSpawn;

	// Use this for initialization
	void Start () {
		timeOfLastSpawn = -timeBetweenSpawns;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > timeOfFirstSpawn && Time.timeSinceLevelLoad >= timeOfLastSpawn + timeBetweenSpawns) {

			timeOfLastSpawn = Time.timeSinceLevelLoad;

			Vector2 spawnPos;
			spawnPos.x = positionsVertical[Random.Range (0, positionsVertical.Length)];
			spawnPos.y = -horizontalBounds + Random.value * 2 * horizontalBounds;

			Instantiate (prefab, (Vector3)spawnPos, Quaternion.identity);
		}
	}
}
