using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rillaboom : Pokemon
	{
		public override string Name => "Rillaboom";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Grassysurge() };
		public override Stats BaseStats => new Stats(100, 125, 90, 60, 70, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Drumbeating() },
			[1] = new List<Move>() { new Moves.Drumbeating(), new Moves.Doublehit(), new Moves.Grassyterrain(), new Moves.Nobleroar(), new Moves.Scratch(), new Moves.Growl(), new Moves.Branchpoke(), new Moves.Taunt() },
			[12] = new List<Move>() { new Moves.Razorleaf() },
			[19] = new List<Move>() { new Moves.Screech() },
			[24] = new List<Move>() { new Moves.Knockoff() },
			[30] = new List<Move>() { new Moves.Slam() },
			[38] = new List<Move>() { new Moves.Uproar() },
			[46] = new List<Move>() { new Moves.Woodhammer() },
			[54] = new List<Move>() { new Moves.Endeavor() },
			[62] = new List<Move>() { new Moves.Boomburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Darkestlariat(), new Moves.Drainpunch(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Frenzyplant(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Leafstorm(), new Moves.Lowkick(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override int Weight => 900;
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