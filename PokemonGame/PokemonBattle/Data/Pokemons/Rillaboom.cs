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
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Grassysurge() };
		public override Stats BaseStats => new Stats(100, 125, 90, 85, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Drumbeating() },
			[1] = new List<Move>() { new Drumbeating(), new Doublehit(), new Grassyterrain(), new Nobleroar(), new Scratch(), new Growl(), new Branchpoke(), new Taunt() },
			[12] = new List<Move>() { new Razorleaf() },
			[19] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Knockoff() },
			[30] = new List<Move>() { new Slam() },
			[38] = new List<Move>() { new Uproar() },
			[46] = new List<Move>() { new Woodhammer() },
			[54] = new List<Move>() { new Endeavor() },
			[62] = new List<Move>() { new Boomburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Attract(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Bulletseed(), new Darkestlariat(), new Drainpunch(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Focusenergy(), new Frenzyplant(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Hypervoice(), new Leafstorm(), new Lowkick(), new Magicalleaf(), new Megakick(), new Megapunch(), new Mudshot(), new Protect(), new Rest(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Solarblade(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Swordsdance(), new Taunt(), new Uproar(), new Uturn(), new Workup() };
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