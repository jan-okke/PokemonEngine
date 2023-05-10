using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sylveon : Pokemon
{
	public override string Name => "Sylveon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pixilate() };
	public override Stats BaseStats => new Stats(95, 65, 65, 110, 130, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Disarmingvoice() },
		[1] = new List<Move>() { new Moves.Disarmingvoice(), new Moves.Covet(), new Moves.Bite(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Babydolleyes() },
		[20] = new List<Move>() { new Moves.Swift() },
		[25] = new List<Move>() { new Moves.Lightscreen() },
		[30] = new List<Move>() { new Moves.Drainingkiss() },
		[35] = new List<Move>() { new Moves.Mistyterrain() },
		[40] = new List<Move>() { new Moves.Skillswap() },
		[45] = new List<Move>() { new Moves.Psychup() },
		[50] = new List<Move>() { new Moves.Moonblast() },
		[55] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Mysticalfire(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Weatherball(), new Moves.Workup() };
	public override int Weight => 235;
	public override int ExpYield => 184;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}