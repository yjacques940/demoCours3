using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//on a créé un gameObject sur le gun a la sortie du trou: bulletEmitter
//ajouter le script pour le mettre dans le gameObject et le bulletemitter dans le bulletemitter
public class fireGun : MonoBehaviour {
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletEmitter;
    [SerializeField] float fireRate = 1;
    private float timerLAstShow = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerLAstShow += Time.deltaTime;//pour éviter de tirer plus d'une balle par seconde
        if(timerLAstShow > fireRate)
        {
            var fire1 = Input.GetAxis("Fire1");
            if (fire1 > 0)
            {
                Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
                timerLAstShow = 0;
            }
        }
       
	}
}
