using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bulldoze : Move
{
	public override string Name => "Bulldoze";
	public override string Description => "The user strikes everything around it by stomping on the ground. It reduces hit Pokémon's Speed.";
	public override int BasePower => 60;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ground;
	public override bool IgnoresProtect => false;
	public Bulldoze()
	{
		CurrentPowerPoints = PowerPoints;
	}
}