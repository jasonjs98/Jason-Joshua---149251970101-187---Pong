using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnArea;
    public int maxpower;
    public Vector2 powerupmin;
    public Vector2 powerupmax;
    public List<GameObject> powerupLateList;
    private List<GameObject> poweruplist;

    public int spawnInterval;
    private float timer;

    private void Start()
    {
        poweruplist = new List<GameObject>();
        timer = 0;
        
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandom();
            timer -= spawnInterval;
            
        }
    }

    public void GenerateRandom()
    {
        GenerateRandom(new Vector2(Random.Range(powerupmin.x, powerupmax.x), Random.Range(powerupmin.y, powerupmax.y)));
    }

    public void GenerateRandom(Vector2 position)
    {
        if (poweruplist.Count >= maxpower)
        {
            return;
        }
        if (position.x < powerupmin.x ||
            position.x > powerupmax.x ||
            position.y < powerupmin.y ||
            position.y > powerupmax.y)
        {
            return;
        }
        int randomIndex = Random.Range(0, powerupLateList.Count);

        GameObject powerUp = Instantiate(powerupLateList[randomIndex], new Vector3(position.x, position.y, powerupLateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);
        poweruplist.Add(powerUp);
    }

    public void Removepowerup(GameObject powerUp)
    {
        poweruplist.Remove(powerUp);
        Destroy(powerUp);
        StartCoroutine(SelfDestruct());
    }

    public void Removeallpower()
    {
        while (poweruplist.Count > 0)
        {
            Removepowerup(poweruplist[0]);
        }
    }

    
    IEnumerator SelfDestruct()
    {
         yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }

   
}
