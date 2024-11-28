using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Text nameText;
    public Image artworkImage;

    public void Setup(string cardName, Sprite artwork)
    {
        nameText.text = cardName;
        artworkImage.sprite = artwork;
    }
}
