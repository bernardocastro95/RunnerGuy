using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeLevel : MonoBehaviour
{
    public GameObject[] section;
    public int xPos = 50;
    public bool createSection = false;
    public int secNum;
    public Character character;

    // Update is called once per frame
    void Update()
    {
       if(createSection == false && character.hit == false)
        {
            createSection = true;
            StartCoroutine(generateSection());
        }
    }

    IEnumerator generateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(xPos, 0,0), Quaternion.identity);
        xPos -= 50;
        yield return new WaitForSeconds(2);
        createSection = false;

        if(character.hit == true)
        {
            yield return null;
        }
    }
}
