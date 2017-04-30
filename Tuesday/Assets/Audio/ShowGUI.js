var ShowGUI :  boolean;


var style : GUIStyle = new GUIStyle(GUI.skin.GetStyle("label"));

var text : String;


function OnTriggerEnter()
{
    ShowGUI = true;
}

function OnTriggerExit()
{
ShowGUI = false;

}


function OnGUI()

{

style.fontSize = 22;
style.normal.textColor = Color.yellow;

if (ShowGUI == true)


GUI.Label(Rect(600,300,600,20),text, style);

}