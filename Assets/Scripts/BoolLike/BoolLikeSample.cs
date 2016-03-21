using UnityEngine;
using System.Collections;

public class BoolLikeSample : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start Test.");
        Debug.Assert(BoolLike.FromBoolLike(0) == false);
        Debug.Assert(BoolLike.FromBoolLike(1) == true);
        Debug.Assert(BoolLike.FromBoolLike(new Nothing<bool>()) == false);
        Debug.Assert(BoolLike.FromBoolLike(new Just<string>("")) == true);
        Debug.Assert(BoolLike.FromBoolLike(new Just<bool>(false)) == true);
        Debug.Assert(BoolLike.FromBoolLike(true) == true);
        Debug.Assert(BoolLike.FromBoolLike(false) == false);
        Debug.Log("End Test.");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
