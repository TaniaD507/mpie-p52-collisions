using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject parent = transform.parent.gameObject;
        Animation animation = parent.GetComponent<Animation>();
        if (!animation.isPlaying)
        {
            animation.Play("OpenDoor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject parent = transform.parent.gameObject;
        Animation animation = parent.GetComponent<Animation>();
        animation.Play("Close");
    }

    private void OnTriggerStay(Collider other)
    {

    }



}

