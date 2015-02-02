using UnityEngine;
using System.Collections.Generic;

public class ObjectFactory : MonoBehaviour {
	public List<GameObject> items = new List<GameObject>();
	private Dictionary<string, GameObject> factory = new Dictionary<string, GameObject>();

	// Use this for initialization
	void Start () 
	{
		foreach (GameObject g in items)
		{
			factory.Add(g.name, g.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public GameObject BuildObjecct(string n, Vector3 pos, Quaternion rot)
	{
		return Instantiate(factory[n], pos, rot) as GameObject;
	}
}
