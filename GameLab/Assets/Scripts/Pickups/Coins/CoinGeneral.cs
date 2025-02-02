using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGeneral : MonoBehaviour
{
    public int value = 0;
    [SerializeField] Transform platformsHolder;
    List<GameObject> platforms;
    int numberOfPlatforms;

    private void Start()
    {
        platforms = new List<GameObject>();
        platformsHolder = GameObject.Find("Platforms").transform;

        foreach (Transform child in platformsHolder)
        {
            platforms.Add(child.gameObject);
        }
    }

    private void Update()
    {
    }

    public void Spawn()
    {
        int rand = Random.Range(0, platforms.Count);
        float offSet = Random.Range(0, platforms[rand].transform.localScale.x / 10);
        if (Random.Range(0,2) == 0)
        {
            offSet *= -1;
        }
        //Debug.Log(offSet);
        gameObject.transform.position = new Vector3(platforms[rand].transform.position.x + offSet, platforms[rand].transform.position.y + 2, platforms[rand].transform.position.z);
    }

    public void PickedUp()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Spawn();
        }
    }
}
