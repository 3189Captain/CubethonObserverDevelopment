using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text milestoneText;

    private void OnEnable()
    {
        PlayerMovement.OnReach50 += MilestoneOne;
        PlayerMovement.OnReach100 += MilestoneTwo;
        PlayerMovement.OnReach150 += MilestoneThree;
    }
    private void OnDisable()
    {
        PlayerMovement.OnReach50 -= MilestoneOne;
        PlayerMovement.OnReach100 -= MilestoneTwo;
        PlayerMovement.OnReach150 -= MilestoneThree;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }

    public void MilestoneOne()
    {
        Debug.Log("50");
        milestoneText.text = "Milestone 1";
    }
    void MilestoneTwo()
    {
        Debug.Log("100");
        milestoneText.text = "Milestone 2";
    }
    void MilestoneThree()
    {
        Debug.Log("150");
        milestoneText.text = "Milestone 3";
    }
}
