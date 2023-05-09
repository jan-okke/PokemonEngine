using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Litwick : Pokemon
{
	public override string Name => "Litwick";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire(), new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(50, 30, 55, 65, 55, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Smog() },
		[4] = new List<Move>() { new Moves.Ember() },
		[8] = new List<Move>() { new Moves.Minimize() },
		[12] = new List<Move>() { new Moves.Confuseray() },
		[16] = new List<Move>() { new Moves.Hex() },
		[20] = new List<Move>() { new Moves.Willowisp() },
		[24] = new List<Move>() { new Moves.Firespin() },
		[28] = new List<Move>() { new Moves.Nightshade() },
		[32] = new List<Move>() { new Moves.Curse() },
		[36] = new List<Move>() { new Moves.Shadowball() },
		[40] = new List<Move>() { new Moves.Inferno() },
		[44] = new List<Move>() { new Moves.Imprison() },
		[48] = new List<Move>() { new Moves.Painsplit() },
		[52] = new List<Move>() { new Moves.Overheat() },
		[56] = new List<Move>() { new Moves.Memento() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Heatwave(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidarmor(), new Moves.Clearsmog(), new Moves.Haze(), new Moves.Powersplit() };
	public override int Weight => 31;
	public override int ExpYield => 55;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}