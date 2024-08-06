using UnityEngine;
using TMPro;

public class TransfornController : MonoBehaviour
{
    enum Coordinates
    {
        X,
        Y,
        Z
    }
    
    [Header("InputFields")] 
    [SerializeField] private TMP_InputField inputMoveX;

    [SerializeField] private TMP_InputField inputMoveY;
    [SerializeField] private TMP_InputField inputRotateZ;
    [SerializeField] private TMP_InputField inputScaleX, inputScaleY;

    [Header("Object")] 
    [SerializeField] private GameObject objectToTransform;
    

    private void Start()
    {
        inputMoveX.onValueChanged.AddListener(delegate { Move(inputMoveX.text, Coordinates.X); });
        inputMoveY.onValueChanged.AddListener(delegate { Move(inputMoveY.text, Coordinates.Y); });
        inputRotateZ.onValueChanged.AddListener(delegate { Rotate(inputRotateZ.text, Coordinates.Z); });
        inputScaleX.onValueChanged.AddListener(delegate { Scale(inputScaleX.text, Coordinates.X); });
        inputScaleY.onValueChanged.AddListener(delegate { Scale(inputScaleY.text, Coordinates.Y); });
    }
    

    private void Move(string arg0, Coordinates coordinate)
    {
        if (float.TryParse(arg0, out var newCoordinates))
        {
            var currentPosition = objectToTransform.transform.position;
            
            switch (coordinate)
            {
                case Coordinates.X:
                    currentPosition.x = newCoordinates;
                    break;
                case Coordinates.Y:
                    currentPosition.y = newCoordinates;
                    break;
            }

            objectToTransform.transform.position = currentPosition;
        }
    }


    private void Rotate(string arg0, Coordinates coordinate)
    {
        if (float.TryParse(arg0, out var newCoordinates))
        {
            var currentRotation = objectToTransform.transform.rotation;

            switch (coordinate)
            {
                case Coordinates.Z:
                    currentRotation.z = newCoordinates;
                    break;
            }

            objectToTransform.transform.rotation = currentRotation;
        }
    }

    private void Scale(string arg0, Coordinates coordinate)
    {
        if (float.TryParse(arg0, out var newCoordinates))
        {
            var currentScale = objectToTransform.transform.localScale;

            switch (coordinate)
            {
                case Coordinates.X:
                    currentScale.x = newCoordinates;
                    break;
                case Coordinates.Y:
                    currentScale.y = newCoordinates;
                    break;
            }

            objectToTransform.transform.localScale = currentScale;
        }
    }
}