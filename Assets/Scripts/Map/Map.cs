using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The job of this script is to spawn hexagonal tiles creating a basic map

public class Map : MonoBehaviour {

    public GameObject go_Hex_Prefab;
    
    //public GameObject go_Police_Station_Prefab;
    
    //Size of the Map in terms of the number of hexagonal tiles and not world space
    int int_Map_Width = 10;     //Columns
    int int_Map_Height = 10;    //Rows

    //Offset of tiles to stagger them
    float fl_xOffset = 0.880f;
    float fl_zOffset = 0.760f;

    //Cheeky little bit of DSA here - Basically stores all the generated Hex tiles into an array that we can access
    //so use this data structure to access and assign values to tiles
    /*

    Boys im having so much trouble with this map shit. I have no idea how to create police stations and stuff.
    How about we leave it for the MVP and just stick to an attack and defence for the MVP as we now have 
    a fully working multiplayer

    private Map[,] map_Tiles;

    public Map GetTiles(int x, int y) {

        if (map_Tiles == null) {
            Debug.LogError("Hexes have not been generated yet.");
        }
        return map_Tiles[x, y];
    }
    */

    // Start is called before the first frame update
    void Start() {
        GenerateMap();
    }

    virtual public void GenerateMap(){

        //map_Tiles = new Map[int_Map_Width, int_Map_Height];

        for (int x = 0; x < int_Map_Width; x++) {

            for (int y = 0; y < int_Map_Height; y++) {

                float fl_xPos = x * fl_xOffset;

                //Get Row
                if (y % 2 == 1) {
                    fl_xPos += fl_xOffset/2f;
                }

                GameObject go_Hex = (GameObject)Instantiate(go_Hex_Prefab, new Vector3( fl_xPos, 0, y * fl_zOffset), Quaternion.identity);      //Create an instance of the hex prefab with the following co-ordinates.             

                go_Hex.name = "Hex_" + x + "_" + y;
                go_Hex.transform.SetParent(this.transform);
                go_Hex.isStatic = true;

                /*
                GameObject.Instatiate(go_Police_Station_Prefab, go_Hex.transform.position, Quaternion.identity go_Hex.transform);
                */

            }
        }

    }

}
