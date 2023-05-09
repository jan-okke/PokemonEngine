using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Fennekin : Pokemon
{
	public override string Name => "Fennekin";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magician() };
	public override Stats BaseStats => new Stats(40, 45, 40, 62, 60, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Ember() },
		[11] = new List<Move>() { new Moves.Howl() },
		[14] = new List<Move>() { new Moves.Flamecharge() },
		[17] = new List<Move>() { new Moves.Psybeam() },
		[20] = new List<Move>() { new Moves.Firespin() },
		[25] = new List<Move>() { new Moves.Luckychant() },
		[27] = new List<Move>() { new Moves.Lightscreen() },
		[31] = new List<Move>() { new Moves.Psyshock() },
		[35] = new List<Move>() { new Moves.Flamethrower() },
		[38] = new List<Move>() { new Moves.Willowisp() },
		[41] = new List<Move>() { new Moves.Psychic() },
		[43] = new List<Move>() { new Moves.Sunnyday() },
		[46] = new List<Move>() { new Moves.Magicroom() },
		[48] = new List<Move>() { new Moves.Fireblast() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Echoedvoice(), new Moves.Embargo(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Overheat(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Toxic(), new Moves.Willowisp(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Heatwave(), new Moves.Hypnosis(), new Moves.Magiccoat(), new Moves.Psychicterrain(), new Moves.Wish() };
	public override int Weight => 94;
	public override int ExpYield => 61;
	public override int CatchRate => 45;
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