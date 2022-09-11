using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float characterSpeed;
    public float gravity = 9.81f;
    public Vector3 velocity = Vector3.zero;
    public GameObject gameOver;
    int score = 0;

    private CharacterController controller;
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        PlayerData pd = new PlayerData();
        //characterSpeed = pd.speed;
       // gameOver.setActive(false);
    }

    void Update()
    {
        

        //Movement X
        Vector3 movementX = Input.GetAxisRaw("Vertical") * Vector3.forward * characterSpeed * Time.deltaTime;
        //Movement Z
        Vector3 movementZ = Input.GetAxisRaw("Horizontal") * Vector3.right * characterSpeed * Time.deltaTime;
        //Movement Y
        Vector3 movementY = Vector3.down* gravity * Time.deltaTime;


        //Set Movement
        Vector3 movement = transform.TransformDirection(movementZ + movementX + movementY);
        velocity = movement;
        
        //Move
        controller.Move(movement);

    }
    public static int ScoreFetcher()
    {
        PlayerController pd = new PlayerController();
        return pd.score;
    }
    public static void ScoreAdd()
    {
        PlayerController pd = new PlayerController();
        pd.score += 1;
    }
}
