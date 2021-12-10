using UnityEngine;
using Mirror;

/*
This is our own network manager that will handle players joining and hosting the game on a server
It inherits the NetworkManager provided by Mirror

When a client connects (Things that will happen client side):
    - Client tries to connect to a server
    - OnStartClient - Always gets called when you start to try and connect to a server
    - OnClientConnect - Only gets called when you actually connect to a server

When a client connects to a server (Things that will happen server side):
    - Server initiates a callback "OnServerConnect" - Saying that a client is tring to connect
    - Once connected theres a small period of time before they are ready to transfer data, and when they're ready
      "OnServerReady" will initiate
    - Then the server will create a player
    - Then another callback will trigger "OnServerAddPlayer" - Telling the server that a player has been added

*/

public class MyNetworkManager : NetworkManager {
    /*
        This section of code will perform Mirror's base logic for when a player joins
        Then it will grab their base component and set their name respective to the number of players in the game
        Can change this later to set their display name to a string that is asked for when they join
    */
    public override void OnServerAddPlayer(NetworkConnection conn) {

        base.OnServerAddPlayer(conn);

        MyNetworkPlayer player = conn.identity.GetComponent<MyNetworkPlayer>();
        player.SetDisplayName($"Player {numPlayers}");

        if (numPlayers == 1) {
            Debug.Log($"There is {numPlayers} player on the server");
        } else {
            Debug.Log($"There are {numPlayers} players on the server");
        }

        Color colour_Display_Colour = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        player.SetDisplayColour(colour_Display_Colour);

    }

}
