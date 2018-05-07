using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour {

    public GameObject[] inGameBones;
    public GameObject[] KinectBones;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < inGameBones.Length; i++)
        {
            var X = KinectBones[i].transform.rotation.eulerAngles.x;
            var Y = KinectBones[i].transform.rotation.eulerAngles.y;
            var Z = KinectBones[i].transform.rotation.eulerAngles.z;

            Vector3 eulerangle = new Vector3(0, 0, Z);

            inGameBones[i].transform.eulerAngles = eulerangle;
        }

    }
}
