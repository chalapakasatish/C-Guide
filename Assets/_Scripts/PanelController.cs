using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject gameWinPanel,gameLosePanel,shopPanel,purchaseSuccessfulPanel;

    [SerializeField]public Stack<GameObject> panelStack = new Stack<GameObject>();
    private void OnGUI()
    {
        var bold = new GUIStyle();
        bold.fontStyle = FontStyle.Bold;
        GUILayout.Label("Items in my stack", bold);
        foreach (var item in panelStack)
        {
            GUILayout.Label(item.name);
        }
    }
    public void ActivatePanel(GameObject panel)
    {
        PushPanel(panel);
    }
    public void DeactivatePanel()
    {
        PopPanel();
    }
    public void PushPanel(GameObject panel)
    {
        //if (panelStack.Count > 0)
        //{
        //    GameObject previousPanel = panelStack.Peek();
        //    // Comment the line because i dont want to close current panel
        //    //previousPanel.SetActive(false);
        //}
        if(panelStack.Contains(panel))
        {
            return;
        }
        panel.SetActive(true);
        panelStack.Push(panel);
    }

    public void PopPanel()
    {
        //if (panelStack.Count > 0)
        //{
            GameObject currentPanel = panelStack.Pop();
            currentPanel.SetActive(false);

            //if (panelStack.Count > 0)
            //{
            //    GameObject previousPanel = panelStack.Peek();
            //    previousPanel.SetActive(true);
            //}
        //}
    }
}
