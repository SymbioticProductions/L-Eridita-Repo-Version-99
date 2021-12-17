using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
/*

public enum GameState { Playerturn, Enemyturn, Won, Lost }

public class TurnFunction : MonoBehaviour
{

    public GameObject Player1;
    public GameObject Player2;
    public GameState state;

    void Start() {
        state = GameState.Playerturn;
    }
    void Update() {
         void EndTurn() {
            state = GameState.Enemyturn;
        }
    }

    public void OnEndTurnBTN() {
        if (state != GameState.Playerturn)
        return;

        StartCoroutine(EndTurn);
    }

}

public class EndTurn : MonoBehaviour {
    public UnityEvent buttonClick;    

    void SwitchTurn() {
        if (buttonClick == null) { buttonClick = new UnityEvent(); }
    }  
    void OnMouseUp()
    {
        print("end turn");
        buttonClick.Invoke();
    }
}
*/