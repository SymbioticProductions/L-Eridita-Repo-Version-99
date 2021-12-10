using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The job of this script is to spawn hexagonal tiles creating a basic map

public class Map : MonoBehaviour {

    public GameObject go_Hex_Prefab;
    public double dbl_Hex_Attack; //attempting to add attack stat to hexes
    public bool bl_Hex_Police; //same here but information on if it has a police station

    //Size of the Map in terms of the number of hexagonal tiles and not world space
    int int_Map_Width = 30;
    int int_Map_Height = 15;//resized

    //Offset of tiles to stagger them
    float fl_xOffset = 0.880f;
    float fl_zOffset = 0.760f;

    // Start is called before the first frame update
    void Start() {

        for (int x = 0; x < int_Map_Width; x++) {

            for (int y = 0; y < int_Map_Height; y++) {

                float fl_xPos = x * fl_xOffset;

                //Get Row
                if (y % 2 == 1) {
                    fl_xPos += fl_xOffset/2f;
                }

                if (x == 0 || x == 20 || y == 0 || y == 10) // outer rim of the board
                {
                    dbl_Hex_Attack = 0.1;
                        bl_Hex_Police = false;
                }
                else if ((x == 5 && y == 7) || (x == 7 && y == 9) || (x == 15 && y == 8)) // three arbitrarily chosen locations
                {
                    bl_Hex_Police = true;
                }
                else if (x == 1 || y == 1 || x == 19 || y == 9) { // second rim I think?
                    dbl_Hex_Attack = 0.2;
                }
                else
                    dbl_Hex_Attack = 0.3; //the rest


                GameObject go_Hex = (GameObject)Instantiate(go_Hex_Prefab, dbl_Hex_Attack, bl_Hex_Police, new Vector3( fl_xPos, 0, y * fl_zOffset), Quaternion.identity);      //Create an instance of the hex prefab with the following co-ordinates.
                                                                                                                                                                               //Treating it as a flat 2D plane using only X and Y, not Z
                /* if you're reading this, apparently I'm passing the function above too many arguments
                 * I can't see how to get it to accept the two new variabls
                 */
           

                go_Hex.name = "Hex_" + x + "_" + y;
                go_Hex.transform.SetParent(this.transform);

                add.hex_Storage<go_Hex.name, dbl_Hex_Attack, bl_Hex_Police>; //does this work?
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
