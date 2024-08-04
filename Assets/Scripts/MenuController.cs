using UnityEngine;

public class MenuController : MonoBehaviour
{
    private bool _isOpen;
    
    public void OpenMenu(GameObject menu)
    {
        _isOpen = !_isOpen;
        menu.SetActive(_isOpen);
    }
    
    public void OpenContextMenu(GameObject menu, GameObject contextMenu)
    {
        menu.SetActive(false);
        contextMenu.SetActive(true);
    }

    public void Back(GameObject menu, GameObject contextMenu)
    {
        contextMenu.SetActive(false);
        menu.SetActive(true);
    }
}
