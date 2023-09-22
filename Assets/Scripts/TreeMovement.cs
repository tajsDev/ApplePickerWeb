using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreeMovement : MonoBehaviour
{
    [Header("Inscribed")]
    public float minVal = 10f;
    public GameObject apple;
    public GameObject greenApple;
    public GameObject blackApple;
    public float speed = 20f;
    public float leftAndRightEdge = 10f ;
    public float changeDirChance = 0.001f;
    public List<GameObject> appleTypes;
    // Start is called before the first frame update
    void Start()
    {
        appleTypes.Add(apple);
        Invoke("DropApple",ScoreTracker.appleDropDelay);
        if(ScoreTracker.spawnGreenApples) {
           appleTypes.Add(greenApple);
        }
        if(ScoreTracker.spawnBlackApples) {
            appleTypes.Add(blackApple);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position =  pos;

        if(pos.x < -leftAndRightEdge ) {
            speed = Mathf.Abs(speed);
        } else if ( pos.x > leftAndRightEdge ) {
            speed = -Mathf.Abs(speed) ;
        } 

    }
    private void FixedUpdate() {
        if (Random.value < changeDirChance ) {
            speed *= -1 ; 
        }
    }
    void DropApple() {
        GameObject tApple;
        int chanceApple = Random.Range(0,appleTypes.Count);
        tApple = Instantiate(appleTypes[chanceApple]);
        tApple.transform.position = transform.position ;
        Invoke("DropApple",ScoreTracker.appleDropDelay); 
    }
}
