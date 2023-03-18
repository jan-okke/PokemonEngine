using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Leafeon : Pokemon
	{
		public override string Name => "Leafeon";
		public override List<Ability> AvailableAbilities => new() {new Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Chlorophyll() };
		public override Stats BaseStats => new Stats(65, 110, 130, 60, 65, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Razorleaf() },
			[1] = new List<Move>() { new Razorleaf(), new Covet(), new Swift(), new Bite(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Leechseed() },
			[25] = new List<Move>() { new Magicalleaf() },
			[30] = new List<Move>() { new Synthesis() },
			[35] = new List<Move>() { new Sunnyday() },
			[40] = new List<Move>() { new Gigadrain() },
			[45] = new List<Move>() { new Swordsdance() },
			[50] = new List<Move>() { new Leafblade() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Batonpass(), new Bodyslam(), new Bulletseed(), new Charm(), new Dig(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Flash(), new Focusenergy(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Leafblade(), new Leafstorm(), new Magicalleaf(), new Payday(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rocksmash(), new Round(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Weatherball(), new Workup(), new Xscissor() };
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
}