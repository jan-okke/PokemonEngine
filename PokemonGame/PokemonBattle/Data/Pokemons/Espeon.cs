using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Espeon : Pokemon
{
	public override string Name => "Espeon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Synchronize() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magicbounce() };
	public override Stats BaseStats => new Stats(65, 65, 60, 130, 95, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Confusion() },
		[1] = new List<Move>() { new Moves.Confusion(), new Moves.Covet(), new Moves.Bite(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Babydolleyes() },
		[20] = new List<Move>() { new Moves.Swift() },
		[25] = new List<Move>() { new Moves.Psybeam() },
		[30] = new List<Move>() { new Moves.Morningsun() },
		[35] = new List<Move>() { new Moves.Powerswap() },
		[40] = new List<Move>() { new Moves.Psychic() },
		[45] = new List<Move>() { new Moves.Psychup() },
		[50] = new List<Move>() { new Moves.Futuresight() },
		[55] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Focusenergy(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Payday(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicfangs(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Weatherball(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 265;
	public override int ExpYield => 184;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}