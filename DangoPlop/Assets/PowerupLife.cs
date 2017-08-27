using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupLife : PowerupParent {
	public override void HandlePowerupAction(float powerupLastingTime){
		powerupMaster.startPowerupAction (PowerupType.Life, powerupLastingTime);
	}
}
