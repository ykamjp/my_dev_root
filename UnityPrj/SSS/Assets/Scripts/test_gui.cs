using UnityEngine;
using System.Collections;

public class test_gui : MonoBehaviour 
{

	public int selGridInt = 0;
    public string[] selStrings = new string[] {"Grid 1", "Grid 2", "Grid 3", "Grid 4"};

	void OnGUI()
	{
		Rect rect = new Rect(200, 10, 400, 100);
		bool isClicked = GUI.Button(rect, "Set UP!!");
		if (isClicked)
		{
			print("Stand by Ready!");
		}
		
		selGridInt = GUI.SelectionGrid(new Rect(25, 25, 100, 30), selGridInt, selStrings, 2);
	}
}