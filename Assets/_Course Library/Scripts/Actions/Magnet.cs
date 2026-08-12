using UnityEngine;

public class MagnetVisualState : MonoBehaviour
{
    public Renderer magnetRenderer;
    public Material inactiveMaterial;
    public Material activeMaterial;

    private void Start()
    {
        SetInactiveState();
    }

    public void SetActiveState()
    {
        magnetRenderer.material = activeMaterial;
    }

    public void SetInactiveState()
    {
        magnetRenderer.material = inactiveMaterial;
    }
}