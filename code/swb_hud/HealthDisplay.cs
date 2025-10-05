using Sandbox.UI;
using Sandbox.UI.Construct;
using SWB.Player;
using SWB.Shared;

namespace SWB.HUD;

public class HealthDisplay : Panel
{
	PlayerBase player;
	Label healthLabel;

	public HealthDisplay( PlayerBase player )
	{
		this.player = player;
		StyleSheet.Load( "/swb_hud/HealthDisplay.cs.scss" );


		healthLabel = Add.Label( "" );
	}

	public override void Tick()
	{
		var isAlive = player.IsAlive;
		SetClass( "hide", !isAlive );

		if ( !isAlive ) return;

		var healthPer = ((float)player.Health) / 100f;

		if ( healthLabel is not null )
		{
			healthLabel.Text = player.Health.ToString();
		}
	}
}
