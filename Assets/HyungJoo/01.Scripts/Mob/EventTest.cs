using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour {
    public void OnFirstHoverEntered() {
        Debug.Log($"{this.gameObject.name} - OnFirstHoverEntered");
    }
    public void OnLastHoverExited() {
        Debug.Log($"{this.gameObject.name} - OnLastHoverExited");
    }
    public void OnHoverEntered() {
        Debug.Log($"{this.gameObject.name} - OnHoverEntered");
    }
    public void OnHoverExited() {
        Debug.Log($"{this.gameObject.name} - OnHoverExited");
    }
    public void OnFirstSelectEntered() {
        Debug.Log($"{this.gameObject.name} - OnFirstSelectEntered");
    }
    public void OnLastSelectExited() {
        Debug.Log($"{this.gameObject.name} - OnHoverEntered");
    }
    public void OnSelectEntered() {
        Debug.Log($"{this.gameObject.name} - OnSelectEntered");
    }
    public void OnSelectExited() {
        Debug.Log($"{this.gameObject.name} - OnSelectExited");
    }
    public void OnActivated() {
        Debug.Log($"{this.gameObject.name} - OnActivated");
    }
    public void OnDeactivated() {
        Debug.Log($"{this.gameObject.name} - OnDisActivated");
    }
}