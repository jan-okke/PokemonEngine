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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Longreach() };
		public override Stats BaseStats => new Stats(78, 75, 75, 70, 70, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl(), new Moves.Leafage(), new Moves.Astonish() },
			[9] = new List<Move>() { new Moves.Peck() },
			[12] = new List<Move>() { new Moves.Shadowsneak() },
			[15] = new List<Move>() { new Moves.Razorleaf() },
			[20] = new List<Move>() { new Moves.Synthesis() },
			[25] = new List<Move>() { new Moves.Pluck() },
			[30] = new List<Move>() { new Moves.Nastyplot() },
			[35] = new List<Move>() { new Moves.Suckerpunch() },
			[40] = new List<Move>() { new Moves.Leafblade() },
			[45] = new List<Move>() { new Moves.Featherdance() },
			[50] = new List<Move>() { new Moves.Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bravebird(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Hiddenpower(), new Moves.Leafblade(), new Moves.Lightscreen(), new Moves.Nastyplot(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Workup() };
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