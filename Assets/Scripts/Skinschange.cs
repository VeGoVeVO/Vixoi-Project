using UnityEngine;

public class Skinschange : MonoBehaviour
{
    public Material[] materials = new Material[10]; //for 10 materials
    public GameObject player;
    public GameObject playerstand;
    public MeshRenderer playerRend;
    public MeshRenderer playerstandRend;
    void start()
    {

        playerRend = GetComponent<MeshRenderer>();
        playerstandRend = GetComponent<MeshRenderer>();


    }
    
public void changeMaterial(int index)
    {
  
        player.GetComponent<MeshRenderer>().material = materials[index];
        playerstand.GetComponent<MeshRenderer>().material = materials[index];
    }

}
