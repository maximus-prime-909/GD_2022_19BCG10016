using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        //Start End Game UI
        Debug.Log("GameEnded");
    }
    
}
