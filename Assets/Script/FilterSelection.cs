using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterSelection : MonoBehaviour {

	private List<GameObject> _filters;
	private int _index;

	// Use this for initialization
	void Start () {
		_filters = new List<GameObject>();

		foreach(Transform t in transform) {
			_filters.Add(t.gameObject);
			t.gameObject.SetActive(false);
		}
		_filters[_index].SetActive(true);
	}

	public void Select(int index) {
		if(index == _index)
			return;

		if(index < 0 || index >= _filters.Count)
			return;

		_filters[_index].SetActive(false);
		_index = index;
		_filters[_index].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
