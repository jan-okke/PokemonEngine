using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sceptile : Pokemon
	{
		public override string Name => "Sceptile";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unburden() };
		public override Stats BaseStats => new Stats(70, 85, 65, 105, 85, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Dualchop() },
			[1] = new List<Move>() { new Dualchop(), new Furycutter(), new Falseswipe(), new Xscissor(), new Energyball(), new Pound(), new Leer(), new Leafage(), new Quickattack() },
			[5] = new List<Move>() { new Megadrain() },
			[12] = new List<Move>() { new Detect() },
			[15] = new List<Move>() { new Quickguard() },
			[20] = new List<Move>() { new Assurance() },
			[25] = new List<Move>() { new Gigadrain() },
			[30] = new List<Move>() { new Slam() },
			[35] = new List<Move>() { new Doubleteam() },
			[42] = new List<Move>() { new Leafblade() },
			[49] = new List<Move>() { new Screech() },
			[56] = new List<Move>() { new Endeavor() },
			[63] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Assurance(), new Attract(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Bulletseed(), new Crosspoison(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Drainpunch(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Frenzyplant(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Leafblade(), new Leafstorm(), new Lowkick(), new Lowsweep(), new Magicalleaf(), new Megakick(), new Megapunch(), new Outrage(), new Protect(), new Rest(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Scaleshot(), new Screech(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Throatchop(), new Thunderpunch(), new Workup(), new Xscissor() };
		public override int Weight => 522;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}