using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRaycasting : MonoBehaviour
{
    [SerializeField] float range;

    private Interactable currentTarget;
    private Camera mainCam;
    // Start is called before the first frame update
    void Awake()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RayCastForInteract();

        if(Input.GetKeyDown(KeyCode.E)){
            if(currentTarget != null){
                currentTarget.OnInteract();
            }
        }
    }

    private void RayCastForInteract(){
        RaycastHit aiming;

        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out aiming, range)){
            Interactable interaction = aiming.collider.GetComponent<Interactable>();
            if (interaction != null){
                if(aiming.distance <= interaction.maxRange){
                    if(currentTarget == null){
                        currentTarget = interaction;
                        currentTarget.OnHoverStart();
                    }else if(currentTarget != interaction){
                        currentTarget.OnHoverEnd();
                        currentTarget = interaction;
                        currentTarget.OnHoverStart();
                    }
                }else{
                    if (currentTarget != null){
                        currentTarget.OnHoverEnd();
                        currentTarget = null;
                    }
                }
            }else{
                if (currentTarget != null){
                        currentTarget.OnHoverEnd();
                        currentTarget = null;
                    }
            }
        }else{
            if (currentTarget != null){
                currentTarget.OnHoverEnd();
                currentTarget = null;
            }
        }
    }
}
