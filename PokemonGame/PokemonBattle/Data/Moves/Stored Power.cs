using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Storedpower : Move
{
	public override string Name => "Stored Power";
	public override string Description => "The user attacks with stored power. The more the user's stats are raised, the greater the damage.";
	public override int BasePower => 20;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Storedpower()
	{
		CurrentPowerPoints = PowerPoints;
	}
}