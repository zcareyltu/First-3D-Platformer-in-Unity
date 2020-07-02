using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

	public float bobSpeed;
	public float rotateSpeed;
	public float bobHeight;

	private Vector3 startPos;
	private Vector3 targetPos;

	private void Awake() {
		startPos = transform.position;
		targetPos = startPos + new Vector3(0, bobHeight, 0);
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = Vector3.MoveTowards(transform.position, targetPos, bobSpeed * Time.deltaTime);
		if(transform.position == targetPos) {
			if(targetPos == startPos) {
				targetPos = startPos + new Vector3(0, bobHeight, 0);
			} else {
				targetPos = startPos;
			}
		}

		transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }
}
