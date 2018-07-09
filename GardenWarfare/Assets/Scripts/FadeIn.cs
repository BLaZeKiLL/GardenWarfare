using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour 
{
    public float FadeInTime;

    private Image FadePanel;
    private Color CurrentColor = Color.black;
	// Use this for initialization
	void Start () 
	{
        FadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.timeSinceLevelLoad < FadeInTime)
        {
            CurrentColor.a -= Time.deltaTime / FadeInTime;
            FadePanel.color = CurrentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
