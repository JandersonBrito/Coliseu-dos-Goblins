using UnityEngine;
using System.Collections;

public class teste : MonoBehaviour {

	public NavMeshAgent nav;
	public Transform destino;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		nav.destination = destino.position;
	}

	void OnTriggerEnter(){

	}
}
