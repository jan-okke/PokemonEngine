using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Plasmafists : Move
{
	public override string Name => "Plasma Fists";
	public override string Description => "The user attacks with electrically charged fists. Normal-type moves become Electric-type.";
	public override int BasePower => 100;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsPunchingMove => true;
	public override bool CanMetronome => false;
	public Plasmafists()
	{
		CurrentPowerPoints = PowerPoints;
	}
}