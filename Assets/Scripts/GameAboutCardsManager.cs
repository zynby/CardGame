using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAboutCardsManager : MonoBehaviour
{
    [SerializeField] private AudioClip _clickClip;
    public void ClickedItemAboutCards() {
      SoundManager.Instance.PlaySound(_clickClip);
   }

   public void ClickedHome() {
      SoundManager.Instance.PlaySound(_clickClip);
      GameManager.Instance.GoToMainMenu();
   }
}
