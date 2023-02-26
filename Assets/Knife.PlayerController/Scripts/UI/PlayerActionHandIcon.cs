using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace KnifePlayerController
{
    public class PlayerActionHandIcon : MonoBehaviour
    {
        public Image Image;
        public GameObject equipObject;

        [SerializeField]
        private PlayerAction playerAction;

        public PlayerAction PlayerAction
        {
            get
            {
                if (playerAction == null)
                    playerAction = GameObject.FindObjectOfType<PlayerAction>();

                return playerAction;
            }

            set
            {
                playerAction = value;
            }
        }

        private void Update()
        {
            Image.enabled = PlayerAction.NeedShowHand;
            equipObject.SetActive(PlayerAction.NeedShowHand);
        }
    }
}