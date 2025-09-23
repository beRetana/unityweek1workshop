using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player performs a Jump.
    /// </summary>
    /// <typeparam name="PlayerJumped"></typeparam>
    public class PlayerJumped : Simulation.Event<PlayerJumped>
    {
        public PlayerController player;

        public override void Execute()
        {
            /// sparking beef between us and audio dep.
            /*
            if (player.audioSource && player.jumpAudio)
                player.audioSource.PlayOneShot(player.jumpAudio);
            */
        }
    }
}