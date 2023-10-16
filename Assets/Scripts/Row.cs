using UnityEngine;

// represents a row of tiles in the wordle puzzle game.
public class Row : MonoBehaviour
{
    // an array of Tile objects that make up the row.
    public Tile[] tiles { get; private set; }

    // gets the word formed by the letters on the tiles in the row.
    public string word
    {
        get
        {
            string word = "";

            for (int i = 0; i < tiles.Length; i++)
            {
                word += tiles[i].letter;
            }

            return word;
        }
    }

    // awake is called when the script instance is being loaded.
    private void Awake()
    {
        tiles = GetComponentsInChildren<Tile>();
    }
}

