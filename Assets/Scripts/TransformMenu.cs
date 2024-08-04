using UnityEngine;
using UnityEngine.UI;

public class TransformMenu : MenuController
{
    [Header("Buttons")]
    [SerializeField] private Button transformButton;

    [SerializeField] private Button moveButton, rotateButton, scaleButton;
    [SerializeField] private Button[] backButtons;

    [Header("Menus")] 
    [SerializeField] private GameObject transformMenu;
    [SerializeField] private GameObject transformButtonsGroup;
    [SerializeField] private GameObject moveMenu, rotateMenu, scaleMenu;

    private void Start()
    {
        transformButton.onClick.AddListener(() => OpenMenu(transformMenu));
        moveButton.onClick.AddListener(() => OpenContextMenu(transformButtonsGroup, moveMenu));
        rotateButton.onClick.AddListener(() => OpenContextMenu(transformButtonsGroup, rotateMenu));
        scaleButton.onClick.AddListener(() => OpenContextMenu(transformButtonsGroup, scaleMenu));

        for (int i = 0; i < backButtons.Length; i++)
        {
            backButtons[i].onClick.AddListener(delegate
            {
                Back(transformButtonsGroup, moveMenu);
                Back(transformButtonsGroup, rotateMenu);
                Back(transformButtonsGroup, scaleMenu);
            });
        }
    }
}
