using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IPointerClickHandler
{
	public bool tap;
	public bool doubleTap;
	public int taps = 0;
	
	public void OnPointerClick(PointerEventData eventData)
	{
		tap = true;
		taps++;
	}
	
}
