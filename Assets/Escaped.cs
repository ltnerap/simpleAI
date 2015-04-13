using UnityEngine;
using System.Collections;

public class Escaped : Condition {

	// Will hold human GameObject
	public GameObject person;
	// Will hold Human script attached to human GameObject
	public Human humanScript;
	// Will hold monster GameObject
	public GameObject monster;
	// Will hold Monster script attached to monster GameObject
	public Monster monsterScript;

	// Constructor
	public Escaped(){
		// Finds GameObject tagged with human
		person = GameObject.FindWithTag ("human");
		// Assigns Human script attached to human GameObject
		humanScript = person.GetComponent<Human> ();
		// Finds GameObject tagged with monster
		monster = GameObject.FindWithTag ("monster");
		// Assigns Monster script attached to monster GameObject
		monsterScript = monster.GetComponent<Monster> ();
	}

	// Tests if condition is fulfilled
	public override bool test(){
		// Get x, y positions of human and monster
		int hX = humanScript.x;
		int hY = humanScript.y;
		int mX = monsterScript.x;
		int mY = monsterScript.y;

		// Test if human and monster are in same room
		Debug.Log ("here");
		return !(InSameRoom(hX, hY, mX, mY));
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
