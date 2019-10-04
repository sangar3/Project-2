using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    private Text boxMessage;
    public Transform playerTrans;
    public GravGun playerGravGun;

    private void Awake()
    {
        boxMessage = GetComponentInChildren<Text>();
        playerTrans = GameObject.Find("FirstPerson-AIO").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerTrans.position.z);

        if (playerTrans.position.z > 18)
        {
            boxMessage.text = "Hold left-click\non an object\nto pick it up";
        }
            
        if (playerGravGun.rigidbody)
        {
            GetComponent<Canvas>().enabled = false;
        }

        transform.LookAt(playerTrans.position);
    }
}
