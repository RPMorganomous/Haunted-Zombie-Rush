using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    [SerializeField] private float objectSpeed = 1;
    [SerializeField] private float resetPosition = -20.6f;
    [SerializeField] private float startPosition = 76.23f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {

        if (!GameManager.instance.GameOver)
        {
            transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime), Space.World);
            //transform.Translate(new Vector3(-1, 0, 0) * (objectSpeed * Time.deltaTime), Space.World);
            //transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime)); ==== old line


            if (transform.localPosition.x <= resetPosition)
            {
                Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
                transform.position = newPos;
            }
        }
	}
}
