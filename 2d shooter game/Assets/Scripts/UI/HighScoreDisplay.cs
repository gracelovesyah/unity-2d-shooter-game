﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Use the TextMeshPro namespace

/// <summary>
/// This class inherits from the UIelement class and handles the display of the high score
/// </summary>
public class HighScoreDisplay : UIelement
{
    [Tooltip("The TMP UI to use for display")]
    public TextMeshProUGUI displayText = null;  // Change to TextMeshProUGUI

    /// <summary>
    /// Description:
    /// Changes the high score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayHighScore()
    {
        if (displayText != null)
        {
            displayText.text = "High: " + GameManager.instance.highScore.ToString();
        }
    }

    /// <summary>
    /// Description:
    /// Overrides the virtual function UpdateUI() of the UIelement class and uses the DisplayHighScore function to update
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
        DisplayHighScore();
    }
}
