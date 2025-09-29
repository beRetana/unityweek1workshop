using UnityEngine;
using Platformer.Gameplay;

namespace Platformer.Mechanics
{
    public class TokenPowerUp : TokenInstance
    {
        protected override void OnPlayerEnter(PlayerController player)
        {
            base.OnPlayerEnter(player);

            player.maxSpeed = 30;
        }
    }
}

