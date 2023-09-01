﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // This replaces the UnityEngine.UI for text purposes

/// <summary>
/// This class inherits from the UIelement class and handles updating the score display
/// </summary>
public class ScoreDisplay : UIelement
{
    [Tooltip("The TMP UI to use for display")]
    public TextMeshProUGUI displayText = null;  // Change the type to TextMeshProUGUI

    /// <summary>
    /// Description:
    /// Updates the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayScore()
    {
        if (displayText != null)
        {
            displayText.text = "Score: " + GameManager.score.ToString();
        }
    }

    /// <summary>
    /// Description:
    /// Overrides the virtual UpdateUI function and uses the DisplayScore to update the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayScore();
    }
}
