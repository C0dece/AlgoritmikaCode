using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    void Start()
    {
        CreatePremitiveSteave();
    }

    private void CreatePremitiveSteave(){
        CreatePremitiveCube(0,0,0);
        CreatePremitiveCube(-0.5f, 1, 0);
        CreatePremitiveCube(0.5f, 1, 0);
        CreatePremitiveCube(0.5f, 2, 0);
        CreatePremitiveCube(-0.5f, 2, 0);
        CreatePremitiveCube(0, 3, 0);
    }

    private void CreatePremitiveCube(float x, float y,float z){
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(x, y, z);
    }
}
