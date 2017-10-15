using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        Vector3 rotation = new Vector3(15,30,45) * Time.deltaTime;
        transform.Rotate(rotation);
    }
}