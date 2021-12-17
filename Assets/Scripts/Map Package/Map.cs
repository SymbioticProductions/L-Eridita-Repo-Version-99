using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

//The job of this script is to spawn hexagonal tiles creating a basic map

public class Map : NetworkBehaviour {

    [SerializeField] private Material Transparent_Material;

    public GameObject go_Hex_Prefab;
    
    //Size of the Map in terms of the number of hexagonal tiles and not world space
    int int_Map_Width = 10;     //Columns
    int int_Map_Height = 10;    //Rows

    //Offset of tiles to stagger them
    float fl_xOffset = 0.880f;
    float fl_zOffset = 0.760f;

    public void GenerateMap(){

        for (int x = 0; x < int_Map_Width; x++) {

            for (int y = 0; y < int_Map_Height; y++) {

                float fl_xPos = x * fl_xOffset;

                //Get Row
                if (y % 2 == 1) {
                    fl_xPos += fl_xOffset/2f;
                }

                GameObject go_Hex = (GameObject)Instantiate(go_Hex_Prefab, new Vector3( fl_xPos, 0, y * fl_zOffset), Quaternion.identity);      //Create an instance of the hex prefab with the following co-ordinates.             

                go_Hex.name = "Hex_" + x + "_" + y;
                go_Hex.layer = LayerMask.NameToLayer("HexTiles");
                go_Hex.transform.SetParent(this.transform);
                go_Hex.isStatic = true;

            }
        }

    }

}
