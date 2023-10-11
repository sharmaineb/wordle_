using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public class State
    {
        public Color fillColor;
        public Color outlineColor;
    }

    public State state { get; private set; }
    public char letter { get; private set; }
    private TextMeshProUGUI text;
    private Image fill;
    private Outline outline;

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        text.text = letter.ToString();
    }

    public void SetState(State state)
    {
        this.state = state;
        fill.color = state.fillColor;
        outline.effectColor = state.outlineColor;
    }
}
