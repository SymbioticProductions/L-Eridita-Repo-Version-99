using UnityEngine;
using Mirror;

//THIS CODE WILL GET THE PLAYERS NAME AND COLOUR AND SEND IT TO THE SERVER AND CLIENT
//SyncVars - Variables that are updated on the server and the client

public class MyNetworkPlayer : NetworkBehaviour {

    [SerializeField] private Renderer displayColourRenderer = null;

    [SyncVar]
    [SerializeField]
    private string str_Display_Name = "Missing Name";    //Players Name

    [SyncVar(hook = nameof(HandleDisplayColourUpdated))]
    [SerializeField]
    private Color colour_Display_Colour = Color.black;  //Create player colour variable

    [Server]
    public void SetDisplayName(string str_New_Display_Name) {
        str_Display_Name = str_New_Display_Name;           //Get the players name
    }

    [Server]
    public void SetDisplayColour(Color colour_New_Display_Colour) {
        colour_Display_Colour = colour_New_Display_Colour;  //Get player colour
    }

    private void HandleDisplayColourUpdated(Color colour_Old_Colour, Color colour_New_Colour) {
        displayColourRenderer.material.SetColor("_Color", colour_New_Colour);
    }

}
