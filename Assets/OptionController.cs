using System.Collections;
using UnityEngine;

/// <summary>
/// Controls target objects behaviour.
/// </summary>
public class ObjectController : MonoBehaviour
{
    /// <summary>
    /// The material to use when this object is inactive (not being gazed at).
    /// </summary>
    public Material InactiveMaterial;

    /// <summary>
    /// The material to use when this object is active (gazed at).
    /// </summary>
    public Material GazedAtMaterial;
    public Material CorrectMaterial;
    public Material WrongMaterial;

    private Renderer _myRenderer;

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        // _startingPosition = transform.parent.localPosition;
        _myRenderer = GetComponent<Renderer>();
        SetMaterial(false);
    }


    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        SetMaterial(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        SetMaterial(false);
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {
        if (gameObject == OptionScript.CorrectOptions[0] && !PlayerMovementScript.clicked1)
        {

            _myRenderer.material = CorrectMaterial;
            PlayerMovementScript.clicked1 = true;
            PlayerMovementScript.speed = 10;
            Debug.Log(gameObject);

        }
        else if (gameObject == OptionScript.CorrectOptions[1] && !PlayerMovementScript.clicked2)
        {

            _myRenderer.material = CorrectMaterial;
            PlayerMovementScript.clicked2 = true;
            PlayerMovementScript.speed = 10;
            Debug.Log(gameObject);

        }

        else if (gameObject == OptionScript.CorrectOptions[2] && !PlayerMovementScript.clicked3)
        {

            _myRenderer.material = CorrectMaterial;
            PlayerMovementScript.clicked3 = true;
            PlayerMovementScript.speed = 10;
            Debug.Log(gameObject); 

        }
        else {
            
            _myRenderer.material = WrongMaterial;
            PlayerMovementScript.clicked1 = false;
            PlayerMovementScript.clicked2 = false;
            PlayerMovementScript.clicked3 = false;

        }
    }


    /// <summary>
    /// Sets this instance's material according to gazedAt status.
    /// </summary>
    ///
    /// <param name="gazedAt">
    /// Value `true` if this object is being gazed at, `false` otherwise.
    /// </param>
    private void SetMaterial(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
