using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject obj;
    float randomX, randomY;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private void Update()
    {
        randomX = Random.Range(-8.5f, 8.5f);
        randomY = Random.Range(-4.5f, 4.5f);
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);

            GameObject objClone = Instantiate(obj, new Vector3(randomX, randomY), Quaternion.identity) as GameObject; 
        }
    }

}
