using UnityEngine;

public class Ballskins : MonoBehaviour
{
    public Material[] materials = new Material[10]; //for 10 materials
    public GameObject playerprev;
    public GameObject player;
    public MeshRenderer playerprevRend;
    public MeshRenderer playerRend;
    void start()
    {

        playerprevRend = GetComponent<MeshRenderer>();
        playerRend = GetComponent<MeshRenderer>();


    }
    
public void changeMaterial(int index)
    {
  
        playerprev.GetComponent<MeshRenderer>().material = materials[index];
        player.GetComponent<MeshRenderer>().material = materials[index];
    }

}
