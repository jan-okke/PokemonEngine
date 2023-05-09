using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Leafeon : Pokemon
{
	public override string Name => "Leafeon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Chlorophyll() };
	public override Stats BaseStats => new Stats(65, 110, 130, 60, 65, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Razorleaf() },
		[1] = new List<Move>() { new Moves.Razorleaf(), new Moves.Covet(), new Moves.Swift(), new Moves.Bite(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Babydolleyes() },
		[20] = new List<Move>() { new Moves.Leechseed() },
		[25] = new List<Move>() { new Moves.Magicalleaf() },
		[30] = new List<Move>() { new Moves.Synthesis() },
		[35] = new List<Move>() { new Moves.Sunnyday() },
		[40] = new List<Move>() { new Moves.Gigadrain() },
		[45] = new List<Move>() { new Moves.Swordsdance() },
		[50] = new List<Move>() { new Moves.Leafblade() },
		[55] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Focusenergy(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Magicalleaf(), new Moves.Payday(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Weatherball(), new Moves.Workup(), new Moves.Xscissor() };
	public override int Weight => 255;
	public override int ExpYield => 184;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}