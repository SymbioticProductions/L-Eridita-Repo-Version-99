using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;


public class TurnIndicatorDisplay : NetworkBehaviour 
{
    public int turnStatus;
    public Text TurnIndicator;

    private void Indicator() {
        if (turnStatus == 0) {
            TurnIndicator.text = "Your Turn!";
        } else {
        if (turnStatus == 1) {
            TurnIndicator.text = "Enemy's Turn!";
        }    
        }

    }
}
