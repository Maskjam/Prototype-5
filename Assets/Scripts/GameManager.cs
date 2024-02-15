using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMpro;

public class GameManager : MonoBehaviour
{
    
    public List<GameObject> targets;
    private float spawnRate = 1;
    private int score;
    public TextMeahProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        scoreText.trxt
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
