using UnityEngine;
using System.Collections;
using UnityEditor;
 
public class ComboBoxTest : MonoBehaviour
{
	GUIContent[] comboBoxList;
	private ComboBox22 comboBoxControl;// = new ComboBox22();
	private GUIStyle listStyle = new GUIStyle();
 	//private Object[] aaLIST;
	private int k;
	
	private void Start()
	{
		print ( "abcde" );
		string sAstroot = Application.dataPath;
		print ( sAstroot + "/Resouces/Animation/pc/mdl0100/" );
		AssetDatabase.LoadAllAssetsAtPath( "Assets/Resouces/Animation/pc/mdl0100");

		k = Resources.FindObjectsOfTypeAll(typeof(AnimationClip)).Length;
		print ( k );
		//Object[] textures = Resources.FindObjectsOfTypeAll(typeof(Texture));
        foreach( Object i in Resources.FindObjectsOfTypeAll(typeof(AnimationClip)) )
		{
			print( i.name );
        }      
		
		comboBoxList = new GUIContent[5];
		comboBoxList[0] = new GUIContent("Thing 1");
		comboBoxList[1] = new GUIContent("Thing 2");
		comboBoxList[2] = new GUIContent("Thing 3");
		comboBoxList[3] = new GUIContent("Thing 4");
		comboBoxList[4] = new GUIContent("Thing 5");
 
		listStyle.normal.textColor = Color.white; 
		listStyle.onHover.background =
		listStyle.hover.background = new Texture2D(2, 2);
		listStyle.padding.left =
		listStyle.padding.right =
		listStyle.padding.top =
		listStyle.padding.bottom = 4;
 
		comboBoxControl = new ComboBox22(new Rect(20, 50, 100, 20), comboBoxList[0], comboBoxList, "button", "box", listStyle);
	}
 
	private void OnGUI () 
	{
		comboBoxControl.Show();
	}
}