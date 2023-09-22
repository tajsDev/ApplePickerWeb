using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject basketPrefab;
    public int numBaskets;
    public float basketBottomY = 0f;
    public float BasketSpaceingY=2f;
    public float basketX = 0;
    public float basketZ = 1;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;
        numBaskets = ScoreTracker.numOfLives;
        for(int i=0; i<ScoreTracker.numOfLives; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY +(BasketSpaceingY * i);
            pos.z = basketZ;
            tBasketGO.transform.position = pos;
            basketList.Add( tBasketGO );
        }
    }
        


    // Update is called once per frame
    void Update()
    {
        if(numBaskets > ScoreTracker.numOfLives && ScoreTracker.numOfLives >= 0 ) {
            numBaskets = ScoreTracker.numOfLives;
		    int basketIndex = basketList.Count-1;
		    GameObject tBasketGO = basketList[basketIndex];
		    basketList.RemoveAt( basketIndex );
		    Destroy( tBasketGO );        
        }
        if(ScoreTracker.numOfLives == 0 )
        {
            SceneManager.LoadScene("Gameover");
        }
    }
}
