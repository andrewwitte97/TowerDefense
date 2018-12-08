using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Node : MonoBehaviour {
	
	public Color notEnoughMoneyColor;
	public Color hoverColor;
	public Vector3 positionOffset;
	
	[Header("Optional")]
	public GameObject turret;
	
	BuildManager buildManager;
	
	private Renderer rend;
	private Color startColor;
	
	void Start  ()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
		
		buildManager = BuildManager.instance;
	}
	
	public Vector3 GetBuildPosition ()
	{
		return transform.position + positionOffset;
	}
	
	void OnMouseDown()
	{
		if(EventSystem.current.IsPointerOverGameObject())
			return;
		
		
			if (!buildManager.CanBuild)
				return;
		
			if(turret != null)
			{
				
			}
			
			buildManager.BuildTurretOn (this);
			
	}
	
	void OnMouseEnter()
	{
		if(EventSystem.current.IsPointerOverGameObject())
			return;
		
		
		if (!buildManager.CanBuild)
				return;
			
		if (buildManager.HasMoney)
		{
			rend.material.color = hoverColor;
		}
		else			
		{
		rend.material.color = notEnoughMoneyColor;
		}
		
	}
	
	void OnMouseExit()
	{
		rend.material.color = startColor;
	}
	
}
