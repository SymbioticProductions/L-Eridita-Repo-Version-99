using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;



public class Tile_Selector : NetworkBehaviour
{
    RaycastHit hit;


    public static int int_Owned_Hex = 0;


    public string str_Display_Name;

    void Update()
    {
        //Sends out a ray from the mouse to return the object it hits
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, LayerMask.GetMask("HexTiles"))) {
            
            //Create a game object based on the collision of the ray
            GameObject go_Hit_Object = hit.collider.transform.gameObject;

            if (Input.GetMouseButtonDown(0)) {

                //If the left mouse button is pressed, find the mesh renderer thats hit
                MeshRenderer hitRenderer = go_Hit_Object.GetComponentInChildren<MeshRenderer>();
                hitRenderer.material.color = Color.grey;

            }

            if (Input.GetMouseButtonUp(0)) {

                MeshRenderer releaseRenderer = go_Hit_Object.GetComponentInChildren<MeshRenderer>();
                releaseRenderer.material.color = Color.green;

                int_Owned_Hex++;
                

                //Check if tile is owned - if yes dont move - else move
                //If yes check player stats against tile stats - if player_stats > tile_stats move and change colour of the tile to the players colour else dont move

            
            }

        }

    } 

}
