using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Rewired;
public class InputTest : MonoBehaviour {

    //rewired player id, should always be zero
    public int playerId = 0;
    Player player;

    public Text[] textInfo;
	void Start ()
    {
        player = ReInput.players.GetPlayer(playerId);
        textInfo = GetComponentsInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < 6; ++i)
        {
            textInfo[i].text = player.GetButton(i).ToString();
        }
	}
}
