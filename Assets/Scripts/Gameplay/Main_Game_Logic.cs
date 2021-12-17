using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;


public class Main_Game_Logic : Map
{
    

    // Start is called before the first frame update
    public void Start()
    {
        GenerateMap();
        

        if (Tile_Selector.int_Owned_Hex > 50)
        {

           

            GameObject display = new GameObject("game over display");
            var game_Over_Display = display.AddComponent<Canvas> ();
            game_Over_Display.renderMode = RenderMode.ScreenSpaceOverlay;

            var buttonObject = new GameObject("Box");
            var image = buttonObject.AddComponent<Image>();
            image.transform.parent = game_Over_Display.transform;
            image.rectTransform.sizeDelta = new Vector2(180, 50);
            image.rectTransform.anchoredPosition = Vector3.zero;
            image.color = new Color(1f, .3f, .3f, .5f);

            var textObject = new GameObject("Text");
            textObject.transform.parent = buttonObject.transform;
            var text = textObject.AddComponent<Text>();
            text.rectTransform.sizeDelta = Vector2.zero;
            text.rectTransform.anchorMin = Vector2.zero;
            text.rectTransform.anchorMax = Vector2.one;
            text.rectTransform.anchoredPosition = new Vector2(.5f, .5f);
            text.text = "The game has been won";
            text.font = Resources.FindObjectsOfTypeAll<Font>()[0];
            text.fontSize = 20;
            text.color = Color.red;
            text.alignment = TextAnchor.MiddleCenter;


        }


    }
}