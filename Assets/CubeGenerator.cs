using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {
    Terrain ter;
    float minX, maxX, minZ, maxZ;
    float newX, newY, newZ;
    public GameObject cubefab;

	// Use this for initialization
	void Start () {
        ter = GetComponent<Terrain>();
        minX = ter.terrainData.bounds.min.x;
        maxX = ter.terrainData.bounds.max.x;
        minZ = ter.terrainData.bounds.min.z;
        maxZ = ter.terrainData.bounds.max.z;
        newY = transform.position.y + 10;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
            newX = Random.Range(minX, maxX);
            newZ = Random.Range(minZ, maxZ);

            Instantiate(cubefab, new Vector3(newX, newY, newZ), Quaternion.identity);
	}
}
