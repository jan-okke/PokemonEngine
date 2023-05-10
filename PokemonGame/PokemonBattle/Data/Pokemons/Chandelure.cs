using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Chandelure : Pokemon
{
	public override string Name => "Chandelure";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire(), new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(60, 55, 90, 145, 90, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Confuseray(), new Moves.Hex(), new Moves.Willowisp(), new Moves.Firespin(), new Moves.Nightshade(), new Moves.Curse(), new Moves.Shadowball(), new Moves.Inferno(), new Moves.Imprison(), new Moves.Painsplit(), new Moves.Overheat(), new Moves.Memento(), new Moves.Astonish(), new Moves.Smog(), new Moves.Ember(), new Moves.Minimize() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp() };
	public override int Weight => 343;
	public override int ExpYield => 260;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}