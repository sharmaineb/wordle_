using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    [System.Serializable]
    public class State
    {
        public Color fillColor; // the color to fill the tile with.
        public Color outlineColor; // the color of the outline of the tile.
    }

    public State state { get; private set; } // the current state of the tile.
    public char letter { get; private set; } // the letter displayed on the tile.
    private TextMeshProUGUI text; // text component for displaying the letter.
    private Image fill; // image component for filling the tile.
    private Outline outline; // outline component for the tile.

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>(); // get the TextMeshProUGUI component.
        fill = GetComponent<Image>(); // get the Image component.
        outline = GetComponent<Outline>(); // get the Outline component.
    }

    // set the letter to be displayed on the tile.
    public void SetLetter(char letter)
    {
        this.letter = letter;
        text.text = letter.ToString(); // update the text to display the letter.
    }

    // set the state of the tile, including fill and outline colors.
    public void SetState(State state)
    {
        this.state = state;
        fill.color = state.fillColor; // set the fill color of the tile.
        outline.effectColor = state.outlineColor; // set the outline color of the tile.
    }
}

