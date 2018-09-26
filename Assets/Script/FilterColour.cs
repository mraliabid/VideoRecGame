using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FilterColour : MonoBehaviour {

	public Slider redSlider, blueSlider, greenSlider;
	private Color colourFilter;
	private RawImage _image;
	private Material _material;

	// Use this for initialization
	void Start () {
		_image = GetComponent<RawImage>();
		
		_material = _image.material;
		colourFilter = _material.color;
		_image.color = colourFilter;

		redSlider.value = colourFilter.r;
		blueSlider.value = colourFilter.b;
		greenSlider.value = colourFilter.g;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateSlider() {
		colourFilter.r = redSlider.value;
		colourFilter.b = blueSlider.value;
		colourFilter.g = greenSlider.value;

		_material.color = colourFilter;
	}
}
