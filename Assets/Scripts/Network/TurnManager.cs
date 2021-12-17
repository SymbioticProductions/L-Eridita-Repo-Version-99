using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TurnManager : NetworkBehaviour {
    public int turnStatus =0;
    void Start() {

    }
    void CurrentTurn() {
        if(turnStatus == 0) {
            Playerturn();
        }
        else if(turnStatus == 1) {
            Enemyturn();
        }
    }

    void Playerturn(){
        if (turnStatus == 0){
        Debug.Log("Player's Turn");
        }
    }
    void Enemyturn(){
        if (turnStatus == 1){
        Debug.Log("Enemy's Turn");
        }
    }

    public void TurnChange() {
        if (turnStatus == 0){
            turnStatus = 1;
        }
        else if (turnStatus == 1){
            turnStatus = 0;
        }
    }
}