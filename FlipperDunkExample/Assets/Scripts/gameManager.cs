using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject pota;
    int point=0;
    Text leveltxt,pointTxt;
    
    bool isPlaying;

    void Start()
    {
        leveltxt=GameObject.Find("levelTxt").GetComponent<Text>();
        pointTxt=GameObject.Find("pointText").GetComponent<Text>();
        leveltxt.text="LEVEL "+SceneManager.GetActiveScene().name;
        pointTxt.text="Point : "+point;
        Vector3 randPosition=new Vector3(-1.41f,Random.Range(-1.6f,2.9f),0);
        GameObject newPota =  Instantiate(pota,randPosition,Quaternion.identity) as GameObject;
        isPlaying=true;

    }  
   public void generateNewPota()
    {
        isPlaying=false;
         if(point<100 && isPlaying==false)
        {
        Vector3 randPosition=new Vector3(-1.41f,Random.Range(-1.6f,2.9f),0);
        GameObject newPota =  Instantiate(pota,randPosition,Quaternion.identity) as GameObject;
        isPlaying=true;
        pointAdd();
        }
    }
    public void pointAdd()
    {
        point++;
        pointTxt.text="Point : "+point;
    }
}
