using UnityEngine;

namespace Platformer.Mechanics
{
    /// <summary>
    /// This class contains the data required for implementing token collection mechanics.
    /// It does not perform animation of the token, this is handled in a batch by the 
    /// TokenController in the scene.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    public class TokenPowerUp : TokenInstance
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        
        protected override void OnPlayerEnter(PlayerController player)
        {
            // What happens when the player collects this power-up?
            // Can we change speed or/and jump height?
        }
    }
}
