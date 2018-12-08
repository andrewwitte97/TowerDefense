using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {
	
	public TurretBlueprint standardTurret;
	public TurretBlueprint missleLauncher;
	public TurretBlueprint laserBeamer;
	
	BuildManager buildManager;
	
	void Start()
	{
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret()
	{
		buildManager.SelectTurretToBuild(standardTurret);
	}

	public void SelectMissleLauncher()
	{
		buildManager.SelectTurretToBuild(missleLauncher);
	}

	public void SelectLaserBeamer()
	{
		buildManager.SelectTurretToBuild(laserBeamer);
	}
}
