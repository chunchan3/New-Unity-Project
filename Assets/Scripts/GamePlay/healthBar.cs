using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    Player_inf Player;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<Player_inf>();
    }
    private void Update()
    {
        CurrentHealth = Player.player_health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
