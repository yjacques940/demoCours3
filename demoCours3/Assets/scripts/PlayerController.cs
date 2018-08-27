using UnityEngine;

public class PlayerController : MonoBehaviour {
    CharacterController characterController;
	// Use this for initialization
	void Start ()
    {
        characterController = GetComponent<CharacterController>();
	}
    //mettre la camera comme enfant du player
    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");//en avant, axe des Z
        var vertical = Input.GetAxis("Vertical");//x = vers le haut
        Vector3 mouvement = new Vector3(horizontal,0,vertical);
        characterController.SimpleMove(mouvement * Time.deltaTime * 500); //*500 parce qu'on a un temps très petit
	}

    //
}
