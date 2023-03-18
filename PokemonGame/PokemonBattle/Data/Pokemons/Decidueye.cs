using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Decidueye : Pokemon
	{
		public override string Name => "Decidueye";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Longreach() };
		public override Stats BaseStats => new Stats(78, 107, 75, 70, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Spiritshackle() },
			[1] = new List<Move>() { new Spiritshackle(), new Phantomforce(), new Leafstorm(), new Uturn(), new Spite(), new Tackle(), new Growl(), new Leafage(), new Astonish() },
			[9] = new List<Move>() { new Peck() },
			[12] = new List<Move>() { new Shadowsneak() },
			[15] = new List<Move>() { new Razorleaf() },
			[20] = new List<Move>() { new Synthesis() },
			[25] = new List<Move>() { new Pluck() },
			[30] = new List<Move>() { new Nastyplot() },
			[37] = new List<Move>() { new Suckerpunch() },
			[44] = new List<Move>() { new Leafblade() },
			[51] = new List<Move>() { new Featherdance() },
			[58] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Airslash(), new Attract(), new Batonpass(), new Bravebird(), new Dualwingbeat(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Frenzyplant(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Hex(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Imprison(), new Leafblade(), new Leafstorm(), new Lightscreen(), new Lowsweep(), new Nastyplot(), new Phantomforce(), new Poltergeist(), new Protect(), new Psychocut(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Uturn(), new Workup() };
		public override int Weight => 366;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}