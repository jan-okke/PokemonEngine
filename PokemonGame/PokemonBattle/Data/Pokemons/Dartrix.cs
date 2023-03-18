using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dartrix : Pokemon
	{
		public override string Name => "Dartrix";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Longreach() };
		public override Stats BaseStats => new Stats(78, 75, 75, 52, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Leafage(), new Astonish() },
			[9] = new List<Move>() { new Peck() },
			[12] = new List<Move>() { new Shadowsneak() },
			[15] = new List<Move>() { new Razorleaf() },
			[20] = new List<Move>() { new Synthesis() },
			[25] = new List<Move>() { new Pluck() },
			[30] = new List<Move>() { new Nastyplot() },
			[35] = new List<Move>() { new Suckerpunch() },
			[40] = new List<Move>() { new Leafblade() },
			[45] = new List<Move>() { new Featherdance() },
			[50] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bravebird(), new Dualwingbeat(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Hiddenpower(), new Leafblade(), new Lightscreen(), new Nastyplot(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Workup() };
		public override int Weight => 160;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}